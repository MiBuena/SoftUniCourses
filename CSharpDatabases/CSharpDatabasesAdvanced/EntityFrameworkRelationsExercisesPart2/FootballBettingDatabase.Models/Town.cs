using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBettingDatabase.Models
{
    public class Town
    {

        public Town()
        {
            this.HostedTeams = new HashSet<Team>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Country Country { get; set; }

        public virtual ICollection<Team> HostedTeams { get; set; } 
    }
}
