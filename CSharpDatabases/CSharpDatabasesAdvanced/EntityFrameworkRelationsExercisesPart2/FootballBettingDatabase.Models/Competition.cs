using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBettingDatabase.Models
{
    public class Competition
    {

        public Competition()
        {
            this.Games = new HashSet<Game>();
            this.Bets = new HashSet<Bet>();
        }


        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public virtual ICollection<Game> Games { get; set; }

        public virtual ICollection<Bet> Bets { get; set; }

    }
}
