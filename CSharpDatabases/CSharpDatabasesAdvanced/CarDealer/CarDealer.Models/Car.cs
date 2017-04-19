using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CarDealer.Models
{
    public class Car
    {
        public Car()
        {
            this.PartsCollection = new HashSet<Part>();
        }
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public long TravelledDistance { get; set; }

        [JsonIgnore]
        public virtual ICollection<Part> PartsCollection { get; set; }
    }
}
