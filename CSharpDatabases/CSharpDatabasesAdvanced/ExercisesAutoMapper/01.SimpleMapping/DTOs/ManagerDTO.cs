using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SimpleMapping.DTOs
{
    class ManagerDTO
    {
        public ManagerDTO()
        {
            this.Employees = new HashSet<EmployeeDTO>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public int Count { get; set; }

        public virtual ICollection<EmployeeDTO> Employees { get; set; }
    }
}
