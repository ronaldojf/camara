using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingControl.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class HasAndBelongsToManyAttribute : Attribute
    {
        private readonly string throughTable;
        private readonly string thisTableForeignKeyColumn;
        private readonly string otherTableForeignKeyColumn;

        public HasAndBelongsToManyAttribute(string throughTable, string thisTableForeignKeyColumn,
                                                string otherTableForeignKeyColumn)
        {
            this.throughTable = throughTable;
            this.thisTableForeignKeyColumn = thisTableForeignKeyColumn;
            this.otherTableForeignKeyColumn = otherTableForeignKeyColumn;
        }

        public string ThroughTable
        {
            get { return this.throughTable; }
        }

        public string ThisTableForeignKeyColumn
        {
            get { return this.thisTableForeignKeyColumn; }
        }

        public string OtherTableForeignKeyColumn
        {
            get { return this.otherTableForeignKeyColumn; }
        }
    }
}
