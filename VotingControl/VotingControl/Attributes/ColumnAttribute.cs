using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VotingControl.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ColumnAttribute : Attribute
    {
        private readonly string name;
        private MySqlDbType _type;

        public ColumnAttribute(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }

        public MySqlDbType Type
        {
            get { return this._type; }
            set
            {
                this.TypeChanged = true;
                this._type = value;
            }
        }

        public bool TypeChanged { get; private set; }
    }
}
