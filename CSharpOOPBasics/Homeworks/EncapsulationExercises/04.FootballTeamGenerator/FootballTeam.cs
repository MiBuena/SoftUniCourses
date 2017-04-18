using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _04.FootballTeamGenerator
{
    class FootballTeam
    {
        private string name;
        private decimal rating;

        public FootballTeam(string name)
        {
            this.Name = name;
            this.PlayersCollection = new List<Player>();
        }

        public List<Player> PlayersCollection { get; set; }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public decimal Rating { get; set; }

        public void AddPlayer(Player player)
        {
            this.PlayersCollection.Add(player);
            this.UpdateRating();
        }

        public void RemovePlayer(string playerName)
        {
            int position = this.PlayersCollection.FindIndex(x=>x.Name==playerName);

            if (position < 0)
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }

            this.PlayersCollection.RemoveAt(position);

            this.UpdateRating();
        }

        public void UpdateRating()
        {
            decimal sum = 0;

            foreach (var element in this.PlayersCollection)
            {
                sum += element.Rating;
            }

            if (this.PlayersCollection.Count != 0)
            {
                this.Rating = Math.Round(sum / this.PlayersCollection.Count);
            }
            else
            {
                this.Rating = 0;
            }
        }


    }
}
