using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Parent
    {

        public Parent(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }


        public string Name { get; set; }
        public string Birthday { get; set; }

        public override string ToString()
        {
            string parent = string.Format("\n{0} {1}", this.Name, this.Birthday);

            return parent;
        }
    }
}
