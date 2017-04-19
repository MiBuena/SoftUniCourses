using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HospitalDatabase.Interfaces
{
    public interface IDiagnose
    {
        int Id { get; set; }
        string Name { get; set; }
        string Comments { get; set; } 
    }
}
