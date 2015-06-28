using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingControl.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class BelongsToAttribute : Attribute
    {
        private readonly string parentTable;

        public BelongsToAttribute(string parentTable)
        {
            this.parentTable = parentTable;
        }

        public string ParentTable
        {
            get { return this.parentTable; }
        }
    }
}
