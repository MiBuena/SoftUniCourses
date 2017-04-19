using System.Collections.Generic;
using System.Text;

namespace _02.AdvancedMapping.DTOs
{
    class ManagerDTO
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public int Count { get; set; }

        public IList<EmployeeDTO> EmployeesHeIsInCharge { get; set; }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{FirstName} {LastName} | Employees: { Count}");
            foreach (var employee in this.EmployeesHeIsInCharge)
            {
                result.AppendLine(employee.ToString());
            }
            return result.ToString().Trim();
        }
    }
}
