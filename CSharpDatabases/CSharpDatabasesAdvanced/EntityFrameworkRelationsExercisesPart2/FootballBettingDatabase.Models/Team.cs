using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBettingDatabase.Models
{
    public class Team
    {

        public Team()
        {
            this.Players = new HashSet<Player>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public byte[] Logo { get; set; }

        public string ThreeLetterInitials { get; set; }

        public Color PrimaryKitColor { get; set; }

        public Color SecondaryKitColor { get; set; }

        public Town Town { get; set; }

        public decimal Budget { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
