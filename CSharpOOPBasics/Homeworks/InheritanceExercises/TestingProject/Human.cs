using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject
{
    class Human
    {
        private string name;

        public Human(string name)
        {

            this.Name = name;
        }

        public virtual string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Less than 5 - Human");
                }

                this.name = value;
            }
        }
    }
}
