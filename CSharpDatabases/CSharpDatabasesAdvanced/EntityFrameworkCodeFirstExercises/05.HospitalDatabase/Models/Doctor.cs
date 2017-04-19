using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.HospitalDatabase.Interfaces;

namespace _05.HospitalDatabase.Models
{
    public class Doctor : IDoctor
    {
        public Doctor(string name, string specialty)
        {
            Name = name;
            Specialty = specialty;
            VisitationsCollection = new List<Visitation>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Specialty { get; set; }

        public ICollection<Visitation> VisitationsCollection { get; set; } 
    }
}
