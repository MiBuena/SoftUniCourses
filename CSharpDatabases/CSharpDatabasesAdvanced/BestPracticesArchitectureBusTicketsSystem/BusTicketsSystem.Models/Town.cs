using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketsSystem.Models
{
    public class Town
    {
        public Town()
        {
            this.CustomersBornInThisTown = new List<Customer>();
            this.BusStations = new List<BusStation>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public virtual ICollection<Customer> CustomersBornInThisTown { get; set; }

        public virtual ICollection<BusStation> BusStations { get; set; }

    }
}
