using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite.Models
{
    class Repair : IRepair
    {

        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public string PartName { get; set; }
        public int HoursWorked { get; set; }

        public override string ToString()
        {
            string printing = $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
            return printing;
        }
    }
}
