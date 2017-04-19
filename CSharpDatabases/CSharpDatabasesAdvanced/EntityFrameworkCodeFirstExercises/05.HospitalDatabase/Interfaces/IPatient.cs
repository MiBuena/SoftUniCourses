using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.HospitalDatabase.Models;

namespace _05.HospitalDatabase.Interfaces
{
    interface IPatient
    {
        int Id { get; set; }

        string FirstName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        string Email { get; set; }

        DateTime DateOfBirth { get; set; }

        byte[] Picture { get; set; }

        bool HasMedicalInsurance { get; set; }

        ICollection<Visitation> VisitationsCollection { get; set; }

        ICollection<Diagnose> DiagnosesCollection { get; set; }

        ICollection<Medicament> MedicamentsCollection { get; set; }
    }
}
