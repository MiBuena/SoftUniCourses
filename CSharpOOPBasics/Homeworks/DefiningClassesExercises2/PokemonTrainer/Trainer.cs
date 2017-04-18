using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    class Trainer
    {

        public Trainer(string name)
        {
            this.Name = name;
            this.PokemonCollection = new List<Pokemon>();
        }

        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List <Pokemon> PokemonCollection { get; set; }

        public override string ToString()
        {
            string trainer = String.Format("{0} {1} {2}", this.Name, this.NumberOfBadges, this.PokemonCollection.Count);
            return trainer;
        }
    }
}
