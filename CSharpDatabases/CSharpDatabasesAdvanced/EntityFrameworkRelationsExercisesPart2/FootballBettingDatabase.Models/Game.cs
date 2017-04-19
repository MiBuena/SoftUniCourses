using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBettingDatabase.Models
{
    public class Game
    {

        public Game()
        {
            this.PlayersInThisGame = new HashSet<Player>();
            this.Bets = new HashSet<Bet>();
        }


        public int Id { get; set; }

        public Team HomeTeam { get; set; }

        public Team AwayTeam { get; set; }

        public int HomeGoals { get; set; }

        public int AwayGoals { get; set; }

        public DateTime DateAndTimeOfTheGame { get; set; }

        public decimal HomeTeamWinBetRate { get; set; }
        public decimal AwayTeamWinBetRate { get; set; }
        public decimal DrawGameBetRate { get; set; }
        public Round Round { get; set; }

        public Competition Competition { get; set; }

        public virtual ICollection<Player> PlayersInThisGame { get; set; }

        public virtual ICollection<Bet> Bets { get; set; }

    }
}
