using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingControl
{
    /// <summary>
    /// Classe utilizada para verificar campos de formulários a partir de alguns de seus eventos.
    /// </summary>
    public class Utils
    {
        /// <summary>
        /// Formata o dinheiro
        /// </summary>
        /// <param name="text">Texto para formatar</param>
        /// <returns>Retorna o texto formatado</returns>
        public static string FormatCurrency(string text, string prefix = "R$")
        {
            if (string.IsNullOrWhiteSpace(text) || !Regex.IsMatch(text, @"\d"))
                text = "0";

            string numeros = Convert.ToInt64(Regex.Match(text, @"[\.|,\d]+").ToString().Replace(".", "").Replace(",", "")).ToString();

            if (numeros.Length < 4)
            {
                string[] letras = new string[4] { "0", "0", "0", "0" };

                for (int i = 0; i < numeros.Length; i++) { letras[i] = numeros[i].ToString(); }

                if (numeros[numeros.Length - 1] == '0')
                {
                    for (int i = 0; i < 5 - numeros.Length; i++) { numeros = "0" + numeros; }
                    numeros = numeros.Insert(numeros.Length - 2, ",");
                }
                else
                    numeros = string.Format("{3}{2},{1}{0}", letras[0], letras[1], letras[2], letras[3]);
            }
            else
            {
                numeros = numeros.Insert(numeros.Length - 2, ",");
            }

            return prefix.Trim() + " " + numeros;
        }

        /// <summary>
        /// Calcula a idade de acordo com uma data inicial e a data atual.
        /// </summary>
        /// <param name="_nascimento">Data inicial.</param>
        /// <returns>Retorna a idade em <c>int</c>.</returns>
        public static int AgeFor(DateTime _nascimento)
        {
            int mesAtual = DateTime.Today.Month;
            int diaAtual = DateTime.Today.Day;

            int idade = DateTime.Today.Year - _nascimento.Year;

            if (mesAtual < _nascimento.Month || (mesAtual == _nascimento.Month && diaAtual < _nascimento.Day))
                idade--;

            return idade;
        }

        /// <summary>
        /// Converte uma data no formato americano para brasileiro
        /// </summary>
        /// <param name="data">Data em <c>ShortStringDate</c> no formato americano ou brasileiro</param>
        /// <returns>Retorna a data no formato brasileiro</returns>
        public static string ToPtBrDate(string _data)
        {
            if (_data.Contains('-'))
            {
                return String.Join("/", _data.Split('-').Reverse<string>());
            }
            else
            {
                return _data;
            }
        }

        /// <summary>
        /// Verifica se uma <c>string</c> pode ser convertida em <c>Int16</c>.
        /// </summary>
        /// <param name="_strNumber">Parâmetro <c>string</c> que será testado.</param>
        /// <returns>Retorna <c>true</c> caso o parâmetro for <c>Int16</c>, caso contrário retorna <c>false</c>.</returns>
        public static bool IsInt16(string _strNumber)
        {
            short result = 0;

            if (Int16.TryParse(_strNumber, out result))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Verifica se uma <c>string</c> pode ser convertida em <c>Int32</c>.
        /// </summary>
        /// <param name="_strNumber">Parâmetro <c>string</c> que será testado.</param>
        /// <returns>Retorna <c>true</c> caso o parâmetro for <c>Int32</c>, caso contrário retorna <c>false</c>.</returns>
        public static bool IsInt32(string _strNumber)
        {
            int result = 0;

            if (Int32.TryParse(_strNumber, out result))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Verifica se uma <c>string</c> pode ser convertida em <c>Int64</c>.
        /// </summary>
        /// <param name="_strNumber">Parâmetro <c>string</c> que será testado.</param>
        /// <returns>Retorna <c>true</c> caso o parâmetro for <c>Int64</c>, caso contrário retorna <c>false</c>.</returns>
        public static bool IsInt64(string _strNumber)
        {
            long result = 0;

            if (Int64.TryParse(_strNumber, out result))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Checa se o valor passado é maior que um comparador.
        /// </summary>
        /// <typeparam name="T">O Tipo dos valores a serem comparados. Especifica o tipo que precisa implementar <c>IComparable</c>.</typeparam>
        /// <param name="value">O valor a ser avaliado</param>
        /// <param name="comparator">O valor para comparar contra</param>
        /// <returns><c>true</c> se o valor original for maior que o comparador; caso contrário <c>false</c></returns>
        public static bool IsGreaterThan<T>(T value, T comparator) where T : IComparable
        {
            return value.CompareTo(comparator) > 0;
        }

        /// <summary>
        /// Checa se o valor passado é menor que um comparador.
        /// </summary>
        /// <typeparam name="T">O Tipo dos valores a serem comparados. Especifica o tipo que precisa implementar <c>IComparable</c>.</typeparam>
        /// <param name="value">O valor a ser avaliado</param>
        /// <param name="comparator">O valor para comparar contra</param>
        /// <returns><c>true</c> se o valor original for menor que o comparador; caso contrário <c>false</c></returns>
        public static bool IsLessThan<T>(T value, T comparator) where T : IComparable
        {
            return value.CompareTo(comparator) < 0;
        }

        /// <summary>
        /// Checa se o valor passado é maior ou igual que um comparador.
        /// </summary>
        /// <typeparam name="T">O Tipo dos valores a serem comparados. Especifica o tipo que precisa implementar <c>IComparable</c>.</typeparam>
        /// <param name="value">O valor a ser avaliado</param>
        /// <param name="comparator">O valor para comparar contra</param>
        /// <returns><c>true</c> se o valor original for maior ou igual que o comparador; caso contrário <c>false</c></returns>
        public static bool IsGreaterThanOrEqualTo<T>(T value, T comparator) where T : IComparable
        {
            return value.CompareTo(comparator) >= 0;
        }

        /// <summary>
        /// Checa se o valor passado é menor ou igual que um comparador.
        /// </summary>
        /// <typeparam name="T">O Tipo dos valores a serem comparados. Especifica o tipo que precisa implementar <c>IComparable</c>.</typeparam>
        /// <param name="value">O valor a ser avaliado</param>
        /// <param name="comparator">O valor para comparar contra</param>
        /// <returns><c>true</c> se o valor original for menor ou igual que o comparador; caso contrário <c>false</c></returns>
        public static bool IsLessThanOrEqualTo<T>(T value, T comparator) where T : IComparable
        {
            return value.CompareTo(comparator) <= 0;
        }

        /// <summary>
        /// Checa o valor passado se está entre um valor mínimo e máximo (incluido o valor mínimo e máximo)
        /// </summary>
        /// <typeparam name="T">O Tipo dos valores a serem comparados. Especifica o tipo que precisa implementar <c>IComparable</c>.</typeparam>
        /// <param name="value">O valor a ser avaliado</param>
        /// <param name="minValue">O menor valor (incluído)</param>
        /// <param name="maxValue">O maior valor (incluído)</param>
        /// <returns><c>true</c> se o valor original estiver incluído na coleção; caso contrário <c>false</c></returns>
        public static bool IsBetween<T>(T value, T minValue, T maxValue) where T : IComparable
        {
            return (value.CompareTo(minValue) >= 0 && value.CompareTo(maxValue) <= 0);
        }

        /// <summary>
        /// Determina se a <c>string</c> passada contém somente caracteres numéricos
        /// </summary>
        /// <param name="value">A <c>string</c> a ser avaliada</param>
        /// <returns><c>true</c> se a <c>string</c> especificada contém somente números; caso contrário <c>false</c></returns>
        public static bool IsNumbersOnly(string value)
        {
            string expression = @"[0-9]+";

            return Regex.Match(value, expression).Value != value;
        }

        /// <summary>
        /// Determina se a <c>string</c> passada contém somente caracteres alpha
        /// </summary>
        /// <param name="value">A <c>string</c> a ser avaliada</param>
        /// <returns><c>true</c> se a <c>string</c> especificada contém somente letras; caso contrário <c>false</c></returns>
        public static bool IsCharactersOnly(string value)
        {
            string expression = @"[A-Za-z]+";

            return Regex.Match(value, expression).Value != value;
        }

        /// <summary>
        /// Determina se a <c>string</c> passada contém somente caracteres alpha e acentos
        /// </summary>
        /// <param name="value">A <c>string</c> a ser avaliada</param>
        /// <returns><c>true</c> se a <c>string</c> especificada contém somente letras e acentos; caso contrário <c>false</c></returns>
        public static bool IsNameFormatOnly(string value)
        {
            string expression = @"[A-Za-zÀ-ú\s]+";

            return Regex.Match(value, expression).Value != value;
        }

        /// <summary>
        /// Determina se a <c>string</c> passada contém somente caracteres alfanuméricos
        /// </summary>
        /// <param name="value">A <c>string</c> a ser avaliada</param>
        /// <returns><c>true</c> se a <c>string</c> especificada contém somente caracteres alfanuméricos; caso contrário <c>false</c></returns>
        public static bool IsAlphaNumeric(string value)
        {
            string expression = @"[A-Za-z0-9]+";
            
            return Regex.Match(value, expression).Value != value;
        }

        /// <summary>
        /// Determina se a <c>string</c> passada é um email válido
        /// </summary>
        /// <param name="value">A <c>string</c> a ser avaliada.</param>
        /// <returns><c>true</c> se a <c>string</c> especificada contém um email válido; caso contrário <c>false</c></returns>
        public static bool IsValidEmail(string value)
        {
            string expression = @"([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)";

            return Regex.Match(value, expression).Value != value;
        }

        /// <summary>
        /// Determina se a <c>string</c> passada é uma URL válida
        /// </summary>
        /// <param name="value">A <c>string</c> a ser avaliada.</param>
        /// <returns><c>true</c> se a <c>string</c> conter uma URL válida; caso contrário <c>false</c></returns>
        public static bool IsValidUrl(string value)
        {
            string expression = @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*" +
                    @"(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_=]*)?";

            return Regex.Match(value, expression).ToString() != value;
        }

        /// <summary>
        /// Converte camelCase para Underscore (palavras separadas por underline)
        /// </summary>
        /// <param name="input">String em camelCase a ser convertida</param>
        /// <returns>String em Underscore</returns>
        public static string ToUnderscore(string input)
        {
            return string.Concat(input.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString().ToLower() : x.ToString().ToLower()));
        }
    }
}
