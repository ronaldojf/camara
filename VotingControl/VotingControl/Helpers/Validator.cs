using System;
using System.Data;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingControl.Bases;
using VotingControl.Attributes;

namespace VotingControl
{
    public class Validator
    {
        /// <summary>
        /// Inicializa uma nova instância de Validator
        /// </summary>
        /// <param name="property">Propriedade a ser validada</param>
        /// <param name="propertyName">Nome da propriedade que será usada posteriormente para saber os erros do propriedade</param>
        /// <param name="propertyGender">Gênero da propriedade(Masculino|Feminino), para ajudar na formulação das mensagens de erro</param>
        public Validator(object property, string propertyName, Genders propertyGender = Genders.Male)
        {
            this.Property = property;
            this.PropertyName = propertyName;
            this.PropertyGender = propertyGender;
            this.IsValid = true;

            this.Errors = new DataTable();
            this.Errors.Columns.Add("Atributo");
            this.Errors.Columns.Add("Mensagem");

            if (property.GetType().Name == Types.String)
                this.PropertyType = Types.String;
            else if (property.GetType().Name == Types.DateTime)
                this.PropertyType = Types.DateTime;
            else if (property.GetType().Name == Types.Double)
                this.PropertyType = Types.Double;
            else
                this.PropertyType = Types.Int32;
        }

        private object Property { get; set; }
        private string PropertyName { get; set; }
        private string PropertyType { get; set; }
        private Genders PropertyGender { get; set; }
        
        /// <summary>
        /// Retorna true se a propriedade é válida, senão false
        /// </summary>
        public bool IsValid { get; private set; }

        /// <summary>
        /// Erros armazenados da propriedade validada
        /// </summary>
        public DataTable Errors { get; private set; }

        /// <summary>
        /// Gêneros das mensagens, (Masculino|Feminino)
        /// </summary>
        public enum Genders { Male, Female }

        private struct MessagesMale
        {
            private static string PluralizeCaracteres(double quantity)
            {
                return (quantity.ToString().Length == 1) ? " caractere" : " caracteres";
            }

            public static string Presence = "não pode ficar vazio";
            public static string SameDateOfTodayOrGreater = "não pode ser anterior a hoje";
            public static string CpfVerification = "CPF inválido";
            public static string CnpjVerification = "CNPJ inválido";

            public static string GreaterThan(double quantity, string type)
            {
                if (type == Types.Double || type == Types.Int32)
                    return "precisa ser maior que " + quantity;
                else
                    return "não pode ter mais que " + quantity + PluralizeCaracteres(quantity);
            }

            public static string GreaterThan(DateTime datetime)
            {
                return "precisa ser maior que " + datetime.ToShortDateString() + " " + datetime.ToShortTimeString();
            }

            public static string GreaterOrEqualsThan(double quantity, string type)
            {
                if (type == Types.Double || type == Types.Int32)
                    return "não pode ser menor que " + quantity;
                else
                    return "precisa ter no mínimo " + quantity + PluralizeCaracteres(quantity);
            }

            public static string GreaterOrEqualsThan(DateTime datetime)
            {
                return "não pode ser menor que " + datetime.ToShortDateString() + " " + datetime.ToShortTimeString();
            }

            public static string LessThan(double quantity, string type)
            {
                if (type == Types.Double || type == Types.Int32)
                    return "precisa ser menor que " + quantity;
                else
                    return "não pode ter " + (quantity) + " ou mais" + PluralizeCaracteres(quantity);
            }

            public static string LessThan(DateTime datetime)
            {
                return "precisa ser menor que " + datetime.ToShortDateString() + " " + datetime.ToShortTimeString();
            }

            public static string LessOrEqualsThan(double quantity, string type)
            {
                if (type == Types.Double || type == Types.Int32)
                    return "não pode ser maior que " + quantity;
                else
                    return "pode ter no máximo " + quantity + PluralizeCaracteres(quantity);
            }

            public static string LessOrEqualsThan(DateTime datetime)
            {
                return "não pode ser maior que " + datetime.ToShortDateString() + " " + datetime.ToShortTimeString();
            }

            public static string Between(double minQuantity, double maxQuantity, string type)
            {
                if (type == Types.Double || type == Types.Int32)
                    return "precisa ser entre " + minQuantity + " e " + maxQuantity;
                else
                    return "precisa estar entre " + minQuantity + " e " + maxQuantity + PluralizeCaracteres(maxQuantity);
            }

            public static string Between(DateTime minDateTime, DateTime maxDateTime)
            {
                return "precisa ser entre " + minDateTime + " e " + maxDateTime;
            }

            public static string Uniqueness(string propertyName)
            {
                return propertyName.Replace("_", " ") + " já foi cadastrado";
            }
        }

        private struct MessagesFemale
        {
            public static string Presence = "não pode ficar vazia";

            public static string Uniqueness(string propertyName)
            {
                return propertyName.Replace("_", " ") + " já foi cadastrada";
            }
        }

        private struct Types
        {
            public static string String = "String";
            public static string Int32 = "Int32";
            public static string Double = "Double";
            public static string DateTime = "DateTime";
        }

        /// <summary>
        /// Valida a propriedade a ser validada se a mesma está presente
        /// </summary>
        /// <param name="isEnumerator">Indica se deve avaliar a propriedade como um Enumerador</param>
        /// <returns>Retorna um objeto Validator com a validação executada</returns>
        public Validator Presence(bool isEnumerator = false)
        {
            double numberWithoutPresence = isEnumerator ? -1d : 0d;
            
            if (this.PropertyType == Types.String && String.IsNullOrWhiteSpace(this.Property.ToString()))
            {
                this.IsValid = false;
                this.Errors.Rows.Add(new object[] { 
                    this.PropertyName,
                    (this.PropertyGender == Genders.Male) ? MessagesMale.Presence : MessagesFemale.Presence
                });
            }
            else if ((this.PropertyType == Types.Double || this.PropertyType == Types.Int32) &&
                    (Convert.ToDouble(this.Property) <= numberWithoutPresence))
            {
                this.IsValid = false;
                this.Errors.Rows.Add(new object[] { 
                    this.PropertyName,
                    (this.PropertyGender == Genders.Male) ? MessagesMale.Presence : MessagesFemale.Presence
                });
            }
            
            return this;
        }

        /// <summary>
        /// Valida se a propriedade(Int32, Double, String) é maior que um número especificado
        /// </summary>
        /// <param name="number">Número de tamanho/quantidade no qual a propriedade não pode ser menor ou igual</param>
        /// <returns>Retorna um objeto Validator com a validação executada</returns>
        public Validator GreaterThan(double number)
        {
            if (((this.PropertyType == Types.Double || this.PropertyType == Types.Int32) &&
                    Convert.ToDouble(this.Property) <= number) ||
                (this.PropertyType == Types.String && this.Property.ToString().Length <= number))
            {
                this.IsValid = false;
                this.Errors.Rows.Add(new object[] { this.PropertyName, MessagesMale.GreaterThan(number, this.PropertyType) });
            }

            return this;
        }

        /// <summary>
        /// Valida se a propriedade é uma data maior que uma data especificada
        /// </summary>
        /// <param name="datetime">Data/Hora no qual a propriedade não pode ser menor ou igual</param>
        /// <returns>Retorna um objeto Validator com a validação executada</returns>
        public Validator GreaterThan(DateTime datetime)
        {
            if (Convert.ToDateTime(this.Property) <= datetime)
            {
                this.IsValid = false;
                this.Errors.Rows.Add(new object[] { this.PropertyName, MessagesMale.GreaterThan(datetime) });
            }

            return this;
        }

        /// <summary>
        /// Valida se a propriedade(Int32, Double, String) é maior ou igual que um número especificado
        /// </summary>
        /// <param name="number">Número de tamanho/quantidade mínimo que a propriedade pode ter</param>
        /// <returns>Retorna um objeto Validator com a validação executada</returns>
        public Validator GreaterOrEqualsThan(double number)
        {
            if (((this.PropertyType == Types.Double || this.PropertyType == Types.Int32) &&
                    Convert.ToDouble(this.Property) < number) ||
                (this.PropertyType == Types.String && this.Property.ToString().Length < number))
            {
                this.IsValid = false;
                this.Errors.Rows.Add(new object[] { this.PropertyName, MessagesMale.GreaterOrEqualsThan(number, this.PropertyType) });
            }

            return this;
        }

        /// <summary>
        /// Valida se a propriedade é uma data maior ou igual que uma data especificada
        /// </summary>
        /// <param name="datetime">Data/Hora no qual a propriedade não pode ser menor</param>
        /// <returns>Retorna um objeto Validator com a validação executada</returns>
        public Validator GreaterOrEqualsThan(DateTime datetime)
        {
            if (Convert.ToDateTime(this.Property) > datetime)
            {
                this.IsValid = false;
                this.Errors.Rows.Add(new object[] { this.PropertyName, MessagesMale.GreaterOrEqualsThan(datetime) });
            }

            return this;
        }

        /// <summary>
        /// Valida se a propriedade(Int32, Double, String) é menor que um número especificado
        /// </summary>
        /// <param name="number">Número de tamanho/quantidade no qual a propriedade não pode ser maior ou igual</param>
        /// <returns>Retorna um objeto Validator com a validação executada</returns>
        public Validator LessThan(double number)
        {
            if (((this.PropertyType == Types.Double || this.PropertyType == Types.Int32) &&
                    Convert.ToDouble(this.Property) >= number) ||
                (this.PropertyType == Types.String && this.Property.ToString().Length >= number))
            {
                this.IsValid = false;
                this.Errors.Rows.Add(new object[] { this.PropertyName, MessagesMale.LessThan(number, this.PropertyType) });
            }

            return this;
        }

        /// <summary>
        /// Valida se a propriedade é uma data menor que a data especificada
        /// </summary>
        /// <param name="datetime">Data/Hora no qual a propriedade não pode ser maior ou igual</param>
        /// <returns>Retorna um objeto Validator com a validação executada</returns>
        public Validator LessThan(DateTime datetime)
        {
            if (Convert.ToDateTime(this.Property) >= datetime)
            {
                this.IsValid = false;
                this.Errors.Rows.Add(new object[] { this.PropertyName, MessagesMale.LessThan(datetime) });
            }

            return this;
        }

        /// <summary>
        /// Valida se a propriedade(Int32, Double, String) é menor ou igual que um número especificado
        /// </summary>
        /// <param name="number">Número de tamanho/quantidade máximo que a propriedade pode ter</param>
        /// <returns>Retorna um objeto Validator com a validação executada</returns>
        public Validator LessOrEqualsThan(double number)
        {
            if (((this.PropertyType == Types.Double || this.PropertyType == Types.Int32) &&
                    Convert.ToDouble(this.Property) > number) ||
                (this.PropertyType == Types.String && this.Property.ToString().Length > number))
            {
                this.IsValid = false;
                this.Errors.Rows.Add(new object[] { this.PropertyName, MessagesMale.LessOrEqualsThan(number, this.PropertyType) });
            }

            return this;
        }

        /// <summary>
        /// Valida se a propriedade é uma data menor ou igual que uma data especificada
        /// </summary>
        /// <param name="datetime">Data/Hora no qual a propriedade não pode ser maior</param>
        /// <returns>Retorna um objeto Validator com a validação executada</returns>
        public Validator LessOrEqualsThan(DateTime datetime)
        {
            if (Convert.ToDateTime(this.Property) < datetime)
            {
                this.IsValid = false;
                this.Errors.Rows.Add(new object[] { this.PropertyName, MessagesMale.LessOrEqualsThan(datetime) });
            }

            return this;
        }

        /// <summary>
        /// Valida se a propriedade(Int32, Double, String) está dentro de número mínimo e máximo especificado
        /// </summary>
        /// <param name="minNumber">Número mínimo no qual a propriedade não pode ter tamanho/quantidade menor</param>
        /// <param name="maxNumber">Número máximo no qual a propriedade não pode ter tamanho/quantidade maior</param>
        /// <returns>Retorna um objeto Validator com a validação executada</returns>
        public Validator Between(double minNumber, double maxNumber)
        {
            if (((this.PropertyType == Types.Double || this.PropertyType == Types.Int32) && 
                    (!(Convert.ToDouble(this.Property) >= minNumber && Convert.ToDouble(this.Property) <= maxNumber))) ||
                ((this.PropertyType == Types.String) && 
                    (!(this.Property.ToString().Length >= minNumber && this.Property.ToString().Length <= maxNumber))))
            {
                this.IsValid = false;
                this.Errors.Rows.Add(new object[] { this.PropertyName, MessagesMale.Between(minNumber, maxNumber, this.PropertyType) });
            }

            return this;
        }

        /// <summary>
        /// Valida se a propriedade está dentro de uma data/hora mínima e máxima especificada
        /// </summary>
        /// <param name="minDateTime">Data/Hora mínima no qual a propriedade não pode ser menor</param>
        /// <param name="maxDateTime">Data/Hora máxima no qual a propriedade não pode ser maior</param>
        /// <returns>Retorna um objeto Validator com a validação executada</returns>
        public Validator Between(DateTime minDateTime, DateTime maxDateTime)
        {
            DateTime property = Convert.ToDateTime(this.Property);

            if (property < minDateTime || property > maxDateTime)
            {
                this.IsValid = false;
                this.Errors.Rows.Add(new object[] { this.PropertyName, MessagesMale.Between(minDateTime, maxDateTime) });
            }

            return this;
        }

        /// <summary>
        /// Valida se a propriedade possui uma data no mesmo dia de hoje ou maior
        /// </summary>
        /// <returns>Retorna um objeto Validator com a validação executada</returns>
        public Validator SameDateOfTodayOrGreater()
        {
            DateTime property = Convert.ToDateTime(this.Property);

            if (property.Date < DateTime.Today.Date)
            {
                this.IsValid = false;
                this.Errors.Rows.Add(new object[] { this.PropertyName, MessagesMale.SameDateOfTodayOrGreater });
            }
        
            return this;
        }

        /// <summary>
        /// Valida se a propriedade possui um CPF correto, de acordo com os dígitos verificadores do mesmo
        /// </summary>
        /// <returns>Retorna um objeto Validator com a validação executada</returns>
        public Validator CpfVerification()
        {
            string cpf = this.Property.ToString().Replace(".", "").Replace("-", "");
            
            if (!Cpf.IsValid(cpf))
            {
                this.IsValid = false;
                this.Errors.Rows.Add(new object[] { this.PropertyName, MessagesMale.CpfVerification });
            }

            return this;
        }

        /// <summary>
        /// Valida se a propriedade possui um CNPJ correto, de acordo com os dígitos verificadores do mesmo
        /// </summary>
        /// <returns>Retorna um objeto Validator com a validação executada</returns>
        public Validator CnpjVerification()
        {
            string cnpj = this.Property.ToString().Replace(".", "").Replace("/", "").Replace("-", "");

            if (!Cnpj.IsValid(cnpj))
            {
                this.IsValid = false;
                this.Errors.Rows.Add(new object[] { this.PropertyName, MessagesMale.CnpjVerification });
            }

            return this;
        }

        public Validator Uniqueness<T>() where T : new()
        {
            T obj = new T();

            object[] whereParameters = new object[2]
            {
                this.PropertyName + " = {0}",
                new object[] { this.Property }
            };

            var result = obj.GetType().GetMethod("Where")
                            .Invoke(obj, whereParameters)
                            .GetType().GetMethod("Exists")
                            .Invoke(obj, null);
            
            if (Convert.ToBoolean(result))
            {
                string message = "";

                if (this.PropertyGender == Genders.Male)
                    message = MessagesMale.Uniqueness(this.PropertyName);
                else
                    message = MessagesFemale.Uniqueness(this.PropertyName);
                
                this.IsValid = false;
                this.Errors.Rows.Add(new object[] { this.PropertyName, message });
            }

            return this;
        }
    }
}
