using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HotelDatabase.Models
{
    public class Customer
    {
        public Customer(string accountNumber, string firstName, string lastName, string phoneNumber, string emergencyName, string emergencyNumber):this(accountNumber, firstName, lastName, phoneNumber, emergencyName, emergencyNumber, null)
        {
        }

        public Customer(string accountNumber, string firstName, string lastName, string phoneNumber, string emergencyName, string emergencyNumber, string notes)
        {
            AccountNumber = accountNumber;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            EmergencyName = emergencyName;
            EmergencyNumber = emergencyNumber;
            Notes = notes;
        }

        public int Id { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string EmergencyName { get; set; }

        [Required]
        public string EmergencyNumber { get; set; }

        [MaxLength(200)]
        public string Notes { get; set; }
    }
}
