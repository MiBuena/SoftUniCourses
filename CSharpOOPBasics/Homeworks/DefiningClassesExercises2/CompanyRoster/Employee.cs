using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoster
{
    class Employee
    {

        public Employee(string name, decimal salary, string position, string department) :this(name, salary, position, department, null)
        {
            
        }

        public Employee(string name, decimal salary, string position, string department, string email):this(name,salary, position, department, email, 0)
        {

        }

        public Employee(string name, decimal salary, string position, string department, int age):this(name, salary, position, department, null, age)
        {

        }

        public Employee(string name, decimal salary, string position, string department, string email, int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = email;
            this.Age = age;
        }

        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            string employee = String.Format("{0} {1:F2}", this.Name, this.Salary);

            if (this.Email == null)
            {
                employee += " n/a";
            }
            else
            {
                employee += " " + this.Email;
            }

            if (this.Age == 0)
            {
                employee += " -1";
            }
            else
            {
                employee += " " + this.Age;
            }

            return employee;
        }
    }
}
