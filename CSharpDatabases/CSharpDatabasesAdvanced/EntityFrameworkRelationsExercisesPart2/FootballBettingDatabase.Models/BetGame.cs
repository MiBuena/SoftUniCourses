using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBettingDatabase.Models
{
    public class BetGame
    {
        [ForeignKey("Game")]
        [Key, Column(Order = 0)]
        public int GameId { get; set; }

        public virtual Game Game { get; set; }

        [ForeignKey("Bet")]
        [Key, Column(Order = 1)]
        public int BetId { get; set; }

        public virtual Bet Bet { get; set; }


        public ResultPrediction ResultPrediction { get; set; }
    }
}
