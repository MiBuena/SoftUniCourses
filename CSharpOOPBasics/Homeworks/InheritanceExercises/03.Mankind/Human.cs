﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mankind
{
    class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if(!char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(this.lastName)}");
                }

                if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }

                this.firstName = value;
            }
        }

        public virtual string LastName
        {
            get { return this.lastName; }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            string human = String.Format($"First Name: {this.FirstName}\nLast Name: {this.LastName}");
            return human;
        }
    }
}
