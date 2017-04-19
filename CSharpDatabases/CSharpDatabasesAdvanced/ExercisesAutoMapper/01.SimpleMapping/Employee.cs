using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SimpleMapping
{
    class Employee
    {

        public Employee()
        {
            this.EmployeesHeIsInCharge = new HashSet<Employee>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public DateTime Birthday { get; set; }

        public bool IsOnHoliday { get; set; }

        public string Address { get; set; }

        public virtual Employee Manager { get; set; }

        public virtual ICollection<Employee> EmployeesHeIsInCharge { get; set; }


    }
}
