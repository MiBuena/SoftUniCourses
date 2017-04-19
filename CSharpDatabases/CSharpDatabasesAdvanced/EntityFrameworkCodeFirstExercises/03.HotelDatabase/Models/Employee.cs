using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HotelDatabase.Models
{
    public class Employee
    {
        public Employee(string firstName, string lastName, string title) : this(firstName, lastName, title, null)
        {
        }

        public Employee(string firstName, string lastName, string title, string notes)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            Notes = notes;
        }

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Title { get; set; }

        [MaxLength(200)]
        public string Notes { get; set; }
    }
}
