using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.Models.Enums;

namespace BusTicketsSystem.Models
{
    public class Customer
    {
        public Customer()
        {
            this.ReviewsCollection = new List<Review>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual Town HomeTown { get; set; }

        public virtual BankAccount BankAccount { get; set; }

        public virtual ICollection<Review> ReviewsCollection { get; set; }




    }
}
