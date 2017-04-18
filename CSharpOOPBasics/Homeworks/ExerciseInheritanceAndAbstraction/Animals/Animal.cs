using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal
    {
        private string name;
        private double age;
        private Gender gender;

        protected Animal(string name, double age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public virtual Gender Gender { get; set; }

        public double Age { get; set; }

        public string Name { get; set; }
    }
}
