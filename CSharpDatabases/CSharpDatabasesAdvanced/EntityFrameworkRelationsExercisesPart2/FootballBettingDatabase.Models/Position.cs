using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBettingDatabase.Models
{
    public class Position
    {

        public Position()
        {
            this.PlayersAtThisPosition = new HashSet<Player>();
        }

        public int Id { get; set; }

        public string TwoLetterName { get; set; }

        public string PositionDescription { get; set; }

        public virtual ICollection<Player> PlayersAtThisPosition { get; set; }  
    }
}
