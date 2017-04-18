using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;



        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
            : this(name, age, null)
        {
        }


        public string Email
        {
            get { return this.email; }
            set
            {
                if (!string.IsNullOrEmpty(value) && !value.Contains("@"))
                {
                    throw new ArgumentException("This is not a valid e-mail");
                }

                this.email = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age should be between 1 and 100");
                }

                this.age = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be null");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            string print = null;

            if (this.email != null)
            {
                print = String.Format("Name: {0}\nAge: {1}\nE-mail: {2}", this.Name, this.Age, this.Email);
            }
            else
            {
                print = String.Format("Name: {0}\nAge: {1}\n", this.Name, this.Age);
            }

            return print;
        }
    }
}
