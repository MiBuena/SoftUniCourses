﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("lastName", "The last name can not be null or empty");
                }

                this.lastName = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("firstName", "The first name can not be null or empty");
                }
                this.firstName = value;
            }
        }
    }
}
