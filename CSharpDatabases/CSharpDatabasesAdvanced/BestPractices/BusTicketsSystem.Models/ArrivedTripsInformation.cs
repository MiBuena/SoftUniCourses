using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketsSystem.Models
{
    class ArrivedTripsInformation
    {
        public int Id { get; set; }

        public DateTime ActualTimeOfArrival { get; set; }

        public Trip Trip { get; set; }
    }
}
