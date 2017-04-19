using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SalesDatabase.Models
{
    public class StoreLocation
    {
        public StoreLocation(string locationName)
        {
            LocationName = locationName;
            SalesCollection = new List<Sale>();
        }

        public int Id { get; set; }
        public string LocationName { get; set; }

        public ICollection<Sale> SalesCollection { get; set; }

    }
}
