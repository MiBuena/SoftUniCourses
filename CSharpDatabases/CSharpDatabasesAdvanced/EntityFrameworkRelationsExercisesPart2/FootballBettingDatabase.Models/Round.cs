using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBettingDatabase.Models
{
    public class Round
    {

        public Round()
        {
            this.Games = new HashSet<Round>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Round> Games { get; set; } 
    }
}
