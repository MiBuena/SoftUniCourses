using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.HospitalDatabase.Interfaces;

namespace _05.HospitalDatabase.Models
{
    public class Medicament : IMedicament
    {
        public Medicament(string name)
        {
            this.Name = name;
        }

        public int Id { get; set; }


        [Required]
        public string Name { get; set; }
    }
}
