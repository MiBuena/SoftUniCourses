using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketsSystem.Models
{
    public class BusCompany
    {
        public BusCompany()
        {
            this.TripsCollection = new List<Trip>();
            this.ReviewsCollection = new List<Review>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Nationality { get; set; }

        public decimal Rating { get; set; }

        public virtual ICollection<Trip> TripsCollection { get; set; }

        public virtual ICollection<Review> ReviewsCollection { get; set; }

    }
}
