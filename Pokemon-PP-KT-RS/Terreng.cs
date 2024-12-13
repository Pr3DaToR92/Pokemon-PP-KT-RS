using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_PP_KT_RS
{
    internal class Terreng
    {
        Pokemon pokemonGrass = new Pokemon("Ivysaur", 100, 5, "Grass", 4);
        

        private string _terrain;
        public Terreng(string terrain)
        {
            _terrain = terrain;

        }

        public void ShowPokemon(string terrain)
        {
            if (terrain == "grass")
            {
                Console.Clear();
                Console.WriteLine("Du møtte på en " + pokemonGrass.PrintVSInfo());
            }
                
        }

        public void PokemonFight(Pokemontrener trainer)
        {
          
        }

    }
}
