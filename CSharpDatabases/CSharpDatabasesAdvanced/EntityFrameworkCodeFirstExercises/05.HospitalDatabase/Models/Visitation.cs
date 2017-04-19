using System;
using System.ComponentModel.DataAnnotations;

namespace _05.HospitalDatabase.Models
{
    public class Visitation
    {
        public Visitation(DateTime date, string comment, Doctor doctor, Patient patient)
        {
            Date = date;
            Comment = comment;
            Doctor = doctor;
            Patient = patient;
        }

        
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }

        [Required]
        public string Comment { get; set; }

        [Required]
        public Doctor Doctor { get; set; }

        [Required]
        public Patient Patient { get; set; }
    }
}