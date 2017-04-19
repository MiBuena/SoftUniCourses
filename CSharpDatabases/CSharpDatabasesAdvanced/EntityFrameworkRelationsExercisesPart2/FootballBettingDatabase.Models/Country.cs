using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBettingDatabase.Models
{
    public class Country
    {

        public Country()
        {
            this.Towns = new HashSet<Town>();
        }


        public int Id { get; set; }

        public string ThreeLetters { get; set; }

        public string Name { get; set; }

        public Continent Continent { get; set; }

        public virtual ICollection<Town> Towns { get; set; } 
    }
}
