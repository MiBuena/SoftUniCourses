using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Child
    {
        public Child(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string Name { get; set; }
        public string Birthday { get; set; }

        public override string ToString()
        {
            string child = String.Format("\n{0} {1}", this.Name, this.Birthday);

            return child;
        }
    }
}
