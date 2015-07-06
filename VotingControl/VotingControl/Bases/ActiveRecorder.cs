using System;
using System.Data;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using VotingControl.Attributes;

namespace VotingControl.Bases
{
    public class ActiveRecorder<T> : DBComunicator where T : ActiveRecorder<T>, new()
    {
        public ActiveRecorder() : base(typeof(T).GetCustomAttribute<TableAttribute>().Name)
        {
            this.OriginalFields = new List<string>();
            this.Fields = new List<string>();
            this.Types = new List<MySqlDbType>();
            this.Values = new List<object>();
            
            this._params = new MySqlParameter[0];

            this._select = base.nomeTabela + ".*";
            this._from = base.nomeTabela;
        }

        private T ObjetoDaClasse { get; set; }

        private List<string> OriginalFields { get; set; }
        private List<string> Fields { get; set; }
        private List<MySqlDbType> Types { get; set; }
        private List<object> Values { get; set; }
        
        private string _select { get; set; }
        private string _from { get; set; }
        private string _join { get; set; }
        private string _where { get; set; }
        private string _orderBy { get; set; }
        private string _groupBy { get; set; }
        private int _limit { get; set; }
        private int _offset { get; set; }

        private MySqlParameter[] _params { get; set; }

        private int _fieldCount = 0;

        public T Select(string selectString)
        {
            this._select = selectString;
            return (T)this;
        }

        public T From(string fromString)
        {
            this._from = fromString;
            return (T)this;
        }

        public T Join(string joinString)
        {
            if (String.IsNullOrWhiteSpace(this._join))
                this._join = joinString;
            else
                this._join += " " + joinString;

            return (T)this;
        }

        public T Where(string conditions, params object[] values)
        {
            List<string> whereFields = new List<string>();
            List<MySqlDbType> whereTypes = new List<MySqlDbType>();
            List<object> whereValues = new List<object>();

            for (int i = 0; i < values.Length; i++)
            {
                string paramName = "param_" + this._fieldCount;

                whereFields.Add(paramName);
                whereTypes.Add(TipoMySqlParaTipoValor(values[i].GetType()));
                whereValues.Add(values[i]); 

                conditions = conditions.Replace("{" + i + "}", "@" + paramName);
                
                this._fieldCount += 1;
            }

            if (String.IsNullOrWhiteSpace(this._where))
            {
                this._params = base.ParamsGenerator(whereFields, whereTypes, whereValues);
                this._where = "(" + conditions + ")";
            }
            else
            {
                List<MySqlParameter> concatParams = new List<MySqlParameter>(this._params);
                concatParams.AddRange(base.ParamsGenerator(whereFields, whereTypes, whereValues));

                this._params = concatParams.ToArray();
                this._where += " AND (" + conditions + ")";
            }

            return (T)this;
        }

        public T OrderBy(string orderByString)
        {
            orderByString = orderByString.Contains(" ") ? orderByString : (orderByString + " ASC");

            if (String.IsNullOrWhiteSpace(this._orderBy))
                this._orderBy = orderByString;
            else
                this._orderBy += ", " + orderByString;

            return (T)this;
        }

        public T GroupBy(string groupByString)
        {
            if (String.IsNullOrWhiteSpace(this._orderBy))
                this._groupBy = groupByString;
            else
                this._groupBy += ", " + groupByString;

            return (T)this;
        }

        public T Limit(int limitQuantity)
        {
            this._limit = limitQuantity;
            return (T)this;
        }

        public T Offset(int offsetQuantity)
        {
            this._offset = offsetQuantity;
            return (T)this;
        }

        public List<T> Buscar()
        {
            this.ObjetoDaClasse = new T();
            RecuperarValoresDoObjeto(this.ObjetoDaClasse);

            return ConvertToChildObjectList(ExecuteSelect());
        }

        public DataTable BuscarEmDataTable()
        {
            this.ObjetoDaClasse = new T();
            RecuperarValoresDoObjeto(this.ObjetoDaClasse);

            return ExecuteSelect();
        }

        public int Count()
        {
            this._select = "COUNT(*) AS counter";
            DataTable dataTable = BuscarEmDataTable();
            
            return Convert.ToInt32(dataTable.Rows[0]["counter"]);
        }

        public bool Exists()
        {
            this._limit = 1;
            return this.Count() > 0;
        }

        public List<T> First(int quantity) { return this.GetCustomOrdenatedQuantityOfData("ASC", quantity); }
        public T First() { return this.GetOneOrdenatedData("ASC", 0); }
        public T Second() { return this.GetOneOrdenatedData("ASC", 1); }
        public T Third() { return this.GetOneOrdenatedData("ASC", 2); }
        public T Fourth() { return this.GetOneOrdenatedData("ASC", 3); }
        public T Fifth() { return this.GetOneOrdenatedData("ASC", 4); }
        public T Last() { return this.GetOneOrdenatedData("DESC", 0); }
        public List<T> Last(int quantity) { return GetCustomOrdenatedQuantityOfData("DESC", quantity); }
 
        protected bool Salvar(T objetoDaClasse)
        {
            if (!base.PossuiErros())
            {
                RecuperarValoresDoObjeto(objetoDaClasse);

                int resultId = 0;

                object id = this.GetPrimaryKeyOf(objetoDaClasse).GetValue(objetoDaClasse);

                if (Int32.TryParse(id.ToString(), out resultId) && resultId > 0)
                {
                    string primaryKeyName = this.GetPrimaryKeyOf(objetoDaClasse)
                        .GetCustomAttribute<ColumnAttribute>()
                        .Name;

                    return base.ExecutarUpdate(primaryKeyName, resultId, this.Fields, this.Values, this.Types);
                }
                else
                    return base.ExecutarInsert(this.Fields, this.Values, this.Types);
            }
            else
                return false;
        }

        protected bool Deletar(T objetoDaClasse)
        {
            if (!base.PossuiErros())
            {
                int resultId = 0;

                PropertyInfo primaryKey = this.GetPrimaryKeyOf(objetoDaClasse);

                object primaryKeyValue = primaryKey.GetValue(objetoDaClasse);

                string primaryKeyName = primaryKey.Name;
                
                if (Int32.TryParse(primaryKeyValue.ToString(), out resultId))
                    return base.ExecutarDelete(primaryKeyName, resultId);
                else
                    return false;
            }
            else
                return false;
        }

        private DataTable ExecuteSelect()
        {
            return base.ExecutarSelect(this._select, this._from, this._join,
                                        this._where, this._orderBy, this._groupBy,
                                        this._limit, this._offset, this._params);
        }

        private void RecuperarValoresDoObjeto(object objetoDaClasse)
        {
            LimparValoresDoObjeto();

            IList<PropertyInfo> props =
                new List<PropertyInfo>(objetoDaClasse
                    .GetType()
                    .GetProperties()
                    .Where(prop => Attribute.IsDefined(prop, typeof(ColumnAttribute))));

            foreach (PropertyInfo prop in props)
            {
                ColumnAttribute columnAttr = prop.GetCustomAttribute<ColumnAttribute>();

                this.OriginalFields.Add(prop.Name);
                this.Fields.Add(columnAttr.Name);
                this.Types.Add(columnAttr.TypeChanged ? (MySqlDbType)columnAttr.Type : TipoMySqlParaTipoValor(prop.PropertyType));
                this.Values.Add(prop.GetValue(objetoDaClasse));
            }
        }

        private MySqlDbType TipoMySqlParaTipoValor(Type tipo)
        {
            if (tipo.Name == "String")
                return MySqlDbType.VarChar;
            else if (tipo.Name == "DateTime")
                return MySqlDbType.DateTime;
            else
                return MySqlDbType.Int32;
        }

        private void LimparValoresDoObjeto()
        {
            this.Types.Clear();
            this.Values.Clear();
            this.Fields.Clear();
            this.OriginalFields.Clear();
        }

        private List<T> ConvertToChildObjectList(DataTable dataTable)
        {
            List<T> objList = new List<T>();

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                var newObj = new T();
                
                for (int i = 0; i < this.Fields.Count; i++)
                {
                    string originalPropName = this.OriginalFields[i];
                    string propName = this.Fields[i];

                    newObj.TrySetProperty(originalPropName, dataTable.Rows[row][propName]);
                }

                objList.Add(newObj);
            }

            return objList;
        }

        private PropertyInfo GetPrimaryKeyOf(object obj)
        {
            return obj
                .GetType()
                .GetProperties()
                .Where(p => Attribute.IsDefined(p, typeof(PrimaryKeyAttribute)))
                .First();
        }

        private List<T> GetCustomOrdenatedQuantityOfData(string ordenation, int quantity, int index = 0)
        {
            this.ObjetoDaClasse = new T();

            string primaryName = this.GetPrimaryKeyOf(this.ObjetoDaClasse)
                .GetCustomAttribute<ColumnAttribute>()
                .Name;
            
            this._from = base.nomeTabela;
            this._limit = quantity;
            this._orderBy = primaryName + " " + ordenation;

            if (index > 0)
                this._offset = index;

            return this.Buscar();
        }

        private T GetOneOrdenatedData(string ordenation, int index)
        {
            return GetCustomOrdenatedQuantityOfData(ordenation, 1, index).First();
        }
    }
}
