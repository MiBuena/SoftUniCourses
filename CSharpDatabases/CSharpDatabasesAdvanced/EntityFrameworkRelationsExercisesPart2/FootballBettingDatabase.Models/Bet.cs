using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBettingDatabase.Models
{
    public class Bet
    {
        public Bet()
        {
            this.Games = new HashSet<Game>();
        }

        public int Id { get; set; }
        public decimal BetMoney { get; set; }
        public DateTime DateAndTimeOfBet { get; set; }
        public User User { get; set; }

        public virtual ICollection<Game> Games { get; set; }

    }
}
