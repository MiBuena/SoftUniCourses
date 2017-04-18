using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReflectionLab.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    class AliasAttribute : Attribute
    {
        private string name;

        public AliasAttribute(string aliasName)
        {
            this.Name = aliasName;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public override bool Equals(object obj)
        {
            return this.Name.Equals(obj);
        }
    }
}
