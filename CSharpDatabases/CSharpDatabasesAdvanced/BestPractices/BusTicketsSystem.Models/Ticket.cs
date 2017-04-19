using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketsSystem.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public string Seat { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Trip Trip { get; set; }
    }
}
