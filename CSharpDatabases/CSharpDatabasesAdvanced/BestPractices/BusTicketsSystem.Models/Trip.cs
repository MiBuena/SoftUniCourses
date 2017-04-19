using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.Models.Enums;

namespace BusTicketsSystem.Models
{
    public class Trip
    {

        public int Id { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public virtual TripStatus Status { get; set; }

        public virtual BusStation OriginBusStation { get; set; }

        public virtual BusStation DestinationBusStation { get; set; }

        public virtual BusCompany BusCompany { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

    }
}
