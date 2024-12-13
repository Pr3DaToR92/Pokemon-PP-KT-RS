using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_PP_KT_RS
{
    internal class Pokemon
    {
        private string _name;
        private int _hp;
        private int _lvl;
        private string _type;
        private int _id;



        public Pokemon(string name, int hp, int lvl, string type, int id)
        {
            _name = name;
            _hp = hp;
            _lvl = lvl;
            _type = type;
            _id = id;
        }


        public void WriteInfo()
        {
            Console.WriteLine(_name + " har id " + _id);
        }

        public string PrintVSInfo()
        {
            return _name + " har" + _hp + "hp";
        }
    }
}
