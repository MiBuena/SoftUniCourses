using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBettingDatabase.Models
{
    public class PlayerStatistics
    {

        [Key]
        [ForeignKey("Game")]
        [Column(Order = 0)]
        public int GameId { get; set; }
        public virtual Game Game { get; set; }

        [Key]
        [ForeignKey("Player")]
        [Column(Order = 1)]
        public int PlayerId { get; set; }

        public virtual Player Player { get; set; }

        public int ScoredGoals { get; set; }

        public int PlayerAssists { get; set; }

        public int PlayedMinutesDuringGame { get; set; }


    }
}
