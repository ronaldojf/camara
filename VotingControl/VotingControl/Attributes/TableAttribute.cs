using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingControl.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class TableAttribute : Attribute
    {
        private readonly string name;

        public TableAttribute(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }
    }
}
