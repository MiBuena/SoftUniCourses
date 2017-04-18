using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Company
    {

        public Company(string name, string department, decimal salary)
        {
            this.Name = name;
            this.Department = department;
            this.Salary = salary;
        }

        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            string company = string.Format("\n{0} {1} {2:F2}", this.Name, this.Department, this.Salary);
            return company;
        }
    }
}
