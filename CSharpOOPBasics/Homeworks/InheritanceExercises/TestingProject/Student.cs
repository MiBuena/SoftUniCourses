using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject
{
    class Student: Human
    {
        private string name;

        public Student(string name) : base(name)
        {
        }

        public override string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Length < 4 Student");
                }

                this.name = value;
            }
        }
    }
}
