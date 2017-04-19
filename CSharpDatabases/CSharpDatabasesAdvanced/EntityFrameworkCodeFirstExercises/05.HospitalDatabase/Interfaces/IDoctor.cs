using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.HospitalDatabase.Models;

namespace _05.HospitalDatabase.Interfaces
{
    public interface IDoctor
    {
        int Id { get; set; }

        string Name { get; set; }
        string Specialty { get; set; }

        ICollection<Visitation> VisitationsCollection { get; set; }
    }
}
