using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.HospitalDatabase.Interfaces;

namespace _05.HospitalDatabase.Models
{
    public class Diagnose : IDiagnose
    {
        public Diagnose(string name, string comments, Patient patient)
        {
            this.Name = name;
            this.Comments = comments;
            this.Patient = patient;
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Comments { get; set; }

        [Required]
        public Patient Patient { get; set; }
    }
}
