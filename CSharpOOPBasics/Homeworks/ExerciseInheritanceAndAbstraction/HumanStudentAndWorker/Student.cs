using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("facultyNumber", "The faculty number can not be null or empty");
                }

                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("facultyNumber", "The faculty number should be between 5 and 10 letters/digits");
                }

                this.facultyNumber = value;
            }
        }
    }
}
