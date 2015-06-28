using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingControl.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class HasManyAttribute : Attribute
    {
        private readonly string foreignKeyTable;
        private readonly string foreignKeyColumn;

        public HasManyAttribute(string foreignKeyTable, string foreignKeyColumn)
        {
            this.foreignKeyTable = foreignKeyTable;
            this.foreignKeyColumn = foreignKeyColumn;
        }

        public string ForeignKeyTable
        {
            get { return this.foreignKeyTable; }
        }

        public string ForeignKeyColumn
        {
            get { return this.foreignKeyColumn; }
        }
    }
}
