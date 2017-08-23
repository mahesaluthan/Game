using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game_again
{
    class Monsters : Indicators
    {
        // class of the monsters. same as the Hero

        
        public Monsters()
        {
            Random chance = new Random();
            int manachance = chance.Next(400, 600);
            int healthchance = chance.Next(800, 1000);
            Health = healthchance;
            Mana = manachance;
        }
        
        public void attack(ref int Mana, ref int enemy)
        {
            if (Mana < 25)
            {
                Console.WriteLine("The Monsters has lose the power");
                Thread.Sleep(1000);
            }
            else
            {
                Random chance = new Random();
                int attackchance = chance.Next(1, 4);

                if (attackchance == 1)
                {
                    Random chances = new Random();
                    int attackchances = chances.Next(50, 100);
                    Console.WriteLine("Monster attack you and make damage {0} to you",attackchances);
                    enemy = enemy - attackchances;
                    Mana = Mana - 25;
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Miss attack from monsters");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
