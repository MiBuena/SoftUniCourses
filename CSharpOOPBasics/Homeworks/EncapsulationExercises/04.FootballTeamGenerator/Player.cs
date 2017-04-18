using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FootballTeamGenerator
{
    class Player
    {
        private string name;
        private decimal endurance;
        private decimal sprint;
        private decimal dribble;
        private decimal passing;
        private decimal shooting;

        public Player(string name, decimal endurance, decimal sprint, decimal dribble, decimal passing, decimal shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            this.Rating = GetRating();
        }

        private decimal GetRating()
        {
            decimal rating = (this.Dribble + this.Endurance + this.Passing + this.Shooting + this.Sprint)/5;

            return rating;
        }

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

        public decimal Endurance
        {
            get { return this.endurance; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Endurance should be between 0 and 100.");
                }

                this.endurance = value;
            }
        }

        public decimal Sprint
        {
            get { return this.sprint; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Sprint should be between 0 and 100.");
                }

                this.sprint = value;
            }
        }

        public decimal Dribble
        {
            get { return this.dribble; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Dribble should be between 0 and 100.");
                }

                this.dribble = value;
            }
        }

        public decimal Passing
        {
            get { return this.passing; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Passing should be between 0 and 100.");
                }

                this.passing = value;
            }
        }

        public decimal Shooting
        {
            get { return this.shooting; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Shooting should be between 0 and 100.");
                }

                this.shooting = value;
            }
        }

        public decimal Rating { get; set; }
    }
}
