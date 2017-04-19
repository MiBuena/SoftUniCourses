using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.HospitalDatabase.Models;

namespace _05.HospitalDatabase.Interfaces
{
    public interface IVisitation
    {
        int Id { get; set; }

        DateTime Date { get; set; }

        string Comments { get; set; } 

        Doctor Doctor { get; set; }
    }
}
