using System;
using System.Collections.Generic;

namespace _02.AdvancedMapping
{
    class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public DateTime Birthday { get; set; }

        public bool IsOnHoliday { get; set; }

        public string Address { get; set; }

        public Employee Manager { get; set; }

        public IList<Employee> EmployeesHeIsInCharge { get; set; }


    }
}
