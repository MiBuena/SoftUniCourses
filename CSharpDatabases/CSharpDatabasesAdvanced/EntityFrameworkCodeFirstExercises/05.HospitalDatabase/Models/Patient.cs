using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.HospitalDatabase.Interfaces;

namespace _05.HospitalDatabase.Models
{
    public class Patient : IPatient
    {
        public Patient(string firstName, string lastName, string address, DateTime dateOfBirth, bool hasMedicalInsurance) : this(firstName, lastName, address, null, dateOfBirth, null, hasMedicalInsurance)
        {
        }

        public Patient(string firstName, string lastName, string address, string email, DateTime dateOfBirth, byte[] picture, bool hasMedicalInsurance)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Email = email;
            this.DateOfBirth = dateOfBirth;
            this.Picture = picture;
            this.HasMedicalInsurance = hasMedicalInsurance;
            this.VisitationsCollection = new List<Visitation>();
            this.DiagnosesCollection = new List<Diagnose>();
            this.MedicamentsCollection = new List<Medicament>();
        }

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        public string Email { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public byte[] Picture { get; set; }


        [Required]
        public bool HasMedicalInsurance { get; set; }


        public ICollection<Visitation> VisitationsCollection { get; set; }

        public ICollection<Diagnose> DiagnosesCollection { get; set; }

        public ICollection<Medicament> MedicamentsCollection { get; set; }



    }
}
