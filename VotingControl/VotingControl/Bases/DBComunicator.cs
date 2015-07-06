using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace VotingControl.Bases
{
    public class DBComunicator : ErrorMessages
    {
        private bool connectionWasOpenedHere = false;

        public DBComunicator(string tableName) : base()
        {
            this.TableName = tableName;
        }

        /// <summary>
        /// Nome da tabela no banco de dados
        /// </summary>
        public string TableName { get; private set; }

        protected MySqlParameter[] ParamsGenerator(List<string> _fields, List<MySqlDbType> _types, List<object> _values)
        {
            MySqlParameter[] parameters = new MySqlParameter[_fields.Count];

            for (int i = 0; i < _fields.Count; i++)
            {
                parameters[i] = new MySqlParameter();
                parameters[i].ParameterName = _fields[i].Insert(0, "@");
                parameters[i].MySqlDbType = _types[i];
                parameters[i].Value = _values[i];
            }

            return parameters;
        }

        private void OpenConnection()
        {
            if (Program.Connection.State == ConnectionState.Closed)
            {
                Program.Connection.Open();
                this.connectionWasOpenedHere = true;
            }
        }

        private void CloseConnection()
        {
            if (this.connectionWasOpenedHere && Program.Connection.State == ConnectionState.Open)
            {
                Program.Connection.Close();
                this.connectionWasOpenedHere = false;
            }
        }

        private bool ExecuteChangesOnDB(MySqlCommand comm, string verb)
        {
            bool isOk = false;

            try { this.OpenConnection(); }
            catch
            {
                base.AddMessage(verb, "Erro ao abrir a conexão com o banco de dados.");
                this.CloseConnection();
                return isOk;
            }

            try { comm.ExecuteNonQuery(); isOk = true; }
            catch (Exception e)
            {
                base.AddMessage(verb, "Não foi possível " + verb + " o registro!\n" + e.Message);
                this.CloseConnection();
                return isOk;
            }

            this.CloseConnection();
            return isOk;
        }

        private DataTable ExecuteSearchOnDB(MySqlCommand comm, MySqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comm.CommandText, Program.Connection);
            dataAdapter.SelectCommand.Parameters.AddRange(parameters);
            
            try { dataAdapter.Fill(dataTable); }
            catch (Exception e)
            {
                base.AddMessage("buscar", "Erro ao realizar consulta no banco de dados. \n" + e.Message);
                this.CloseConnection();
                return new DataTable();
            }

            this.CloseConnection();
            return dataTable;
        }

        /// <summary>
        /// Executa o comando SQL Insert.
        /// </summary>
        /// <param name="_fields">Os campos aonde serão gravados.</param>
        /// <param name="_values">Os valores que serão gravados nos campos.</param>
        /// <param name="_types">Os tipos dos valores que serão gravados.</param>
        /// <returns>Retorna true caso o registro tenha sido inserido com sucesso, senão retorna false</returns>
        public bool ExecuteInsert(List<string> _fields, List<object> _values, List<MySqlDbType> _types)
        {
            MySqlParameter[] parameters = ParamsGenerator(_fields, _types, _values);

            MySqlCommand comm = new MySqlCommand("INSERT INTO " + this.TableName + " (" + string.Join(", ", _fields) +
                                    ") VALUES (@" + string.Join(", @", _fields) + ")", Program.Connection);

            comm.Parameters.AddRange(parameters);

            return ExecuteChangesOnDB(comm, Verbs.Create);
        }

        /// <summary>
        /// Executa o comando SQL Update.
        /// </summary>
        /// <param name="_primaryKeyName">Nome da chave primária no banco.</param>
        /// <param name="_id">Chave primária do registro.</param>
        /// <param name="_fields">Os campos aonde serão gravados.</param>
        /// <param name="_values">Os valores que serão gravados nos campos.</param>
        /// <param name="_types">Os tipos dos valores que serão gravados.</param>
        /// <returns>Retorna true caso o registro tenha sido atualizadp com sucesso, senão retorna false</returns>
        public bool ExecuteUpdate(string _primaryKeyName, int _id, List<string> _fields, List<object> _values, List<MySqlDbType> _types)
        {
            MySqlParameter[] parameters = ParamsGenerator(_fields, _types, _values);

            string setString = "";

            for (int i = 0; i < _fields.Count; i++)
                setString += _fields[i] + " = @" + _fields[i] + ", ";

            MySqlCommand comm = new MySqlCommand("UPDATE " + this.TableName + " SET " + setString.Substring(0, setString.Length - 2) +
                                " WHERE " + this.TableName + "." + _primaryKeyName + " = " + _id, Program.Connection);

            comm.Parameters.AddRange(parameters);

            return ExecuteChangesOnDB(comm, Verbs.Update);
        }

        /// <summary>
        /// Deleta o registro pela chave primária.
        /// </summary>
        /// <param name="_primaryKeyName">Nome da chave primária no banco.</param>
        /// <param name="_id">Chave primária do registro.</param>
        /// <returns>Retorna true se a operação for executada com sucesso, senão false</returns>
        public bool ExecuteDelete(string _primaryKeyName, int _id)
        {
            MySqlCommand comm = new MySqlCommand("DELETE FROM " + this.TableName + " WHERE " + _primaryKeyName + " = " + _id,
                Program.Connection);

            return ExecuteChangesOnDB(comm, Verbs.Delete);
        }

        public DataTable ExecuteSelect(string selectString,
                                                 string fromString,
                                                 string joinString,
                                                 string whereString,
                                                 string orderString,
                                                 string groupString,
                                                 int limit,
                                                 int offset,
                                                 MySqlParameter[] whereParameters)
        {
            string query = string.Format("SELECT {0} FROM {1}", selectString, fromString);

            if (!String.IsNullOrWhiteSpace(joinString))
                query += (" " + joinString);

            if (!String.IsNullOrWhiteSpace(whereString))
                query += (" WHERE (" + whereString + ")");

            if (!String.IsNullOrWhiteSpace(orderString))
                query += (" ORDER BY " + orderString);

            if (!String.IsNullOrWhiteSpace(groupString))
                query += (" GROUP BY " + groupString);

            if (limit > 0)
                query += (" LIMIT " + limit);

            if (offset > 0)
                query += (" OFFSET " + offset);

            MySqlCommand comm = new MySqlCommand(query, Program.Connection);
            
            return ExecuteSearchOnDB(comm, whereParameters);
        }
    }
}
