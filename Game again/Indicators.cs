using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_again
{
    class Indicators //in this class we input the indicator of the Hero
    {
        public int _health;                 // Health Point
        public int _mana;                   // Mana Point
        public string _specialattack;       // special attack
        public string _name;                // name
        
        public int Health       // this method is for processing the Health with get and set
        {
            get { return _health; }
            set { _health = value; }
        }

        public int Mana         // this method is for processing the Mana with get and set
        {
            get { return _mana; }
            set { _mana = value; }
        }

        public string Name      // this method is for processing the Name with get and set
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Special_Attack        // this method is for processing the Special Attack with get and set
        {
            get { return _specialattack; }
            set { _specialattack = value; }
        }
    }
}
