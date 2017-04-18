using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MilitaryElite.Interfaces
{
    interface IRepair
    {
        string PartName { get; set; }

        int HoursWorked { get; set; }
    }
}
