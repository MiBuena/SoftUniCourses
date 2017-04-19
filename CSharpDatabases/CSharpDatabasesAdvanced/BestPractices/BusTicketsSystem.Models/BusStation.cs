using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketsSystem.Models
{
    public class BusStation
    {
        public BusStation()
        {
            this.OriginTrips = new List<Trip>();
            this.DestinationTrips = new List<Trip>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Town Town { get; set; }

        [InverseProperty("OriginBusStation")]
        public virtual ICollection<Trip> OriginTrips { get; set; }

        [InverseProperty("DestinationBusStation")]
        public virtual ICollection<Trip> DestinationTrips { get; set; }
    }
}
