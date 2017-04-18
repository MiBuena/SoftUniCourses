using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Pokemon
    {

        public Pokemon(string pokemonName, string pokemonType)
        {
            this.PokemonName = pokemonName;
            this.PokemonType = pokemonType;
        }


        public string PokemonName { get; set; }
        public string PokemonType { get; set; }


        public override string ToString()
        {
            string pokemon = string.Format("\n{0} {1}", this.PokemonName, this.PokemonType);

            return pokemon;
        }
    }
}
