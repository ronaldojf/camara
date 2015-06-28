using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingControl.Attributes
{
    [AttributeUsage(AttributeTargets.Field|AttributeTargets.Property)]
    public sealed class PrimaryKeyAttribute : Attribute
    {
        public PrimaryKeyAttribute() { }
    }
}
