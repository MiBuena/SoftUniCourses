using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBettingDatabase.Models
{
    public class Player
    {

        public Player()
        {
            this.GamesThePlayerPlaysIn = new HashSet<Game>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string SquadNumber { get; set; }

        public Team Team { get; set; }

        public Position Position { get; set; }

        public bool IsCurrentlyInjured { get; set; }

        public virtual ICollection<Game> GamesThePlayerPlaysIn { get; set; } 

    }
}
