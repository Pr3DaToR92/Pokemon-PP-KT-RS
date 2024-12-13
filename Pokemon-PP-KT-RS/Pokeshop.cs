using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_PP_KT_RS
{
    internal class Pokeshop
    {
        public int _pokeballs { get; private set; }
        public int _potion { get; private set; }

        public Pokeshop(int pokeballs, int potion)
        {
            _pokeballs = pokeballs;
            _potion = potion;
        }

    }
}
