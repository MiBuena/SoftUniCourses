using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketsSystem.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public decimal Grade { get; set; }

        public virtual BusStation BusStation { get; set; }

        public virtual Customer Customer { get; set; }

        public DateTime DateAndTimeOfPublishing { get; set; }

        public virtual BusCompany BusCompany { get; set; }

    }
}
