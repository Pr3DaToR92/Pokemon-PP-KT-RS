using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_PP_KT_RS
{
    internal class Pokemontrener
    {
        private string _name;
        private int _cash;
        private int _pokeballs;
        private int _potions;
        public Pokemon _startPokemon {  get; private set; }




        public Pokemontrener(string name, Pokemon startPokemon, int cash)
        {
            _name = name;
            _startPokemon = startPokemon;
            _cash = cash;
        }

        public void BuyPokeball()
        {
            _pokeballs++;
            _cash -= 10;
        }

        public void BuyPotion()
        {
            _potions++;
            _cash -= 10;
        }
    }
}
