using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game_again
{
    class Orc : Indicators
    {
        public Orc()        //indicator of the Hero Orc
        {
            Health = 750;
            Mana = 400;
            Name = "Orc";
            Special_Attack = "Bone Crusher";
        }

        public void Attack(ref  int enemy, ref int Mana)        //this method is the same method with another attack 
        {
            if (Mana < 75)
            {
                Console.WriteLine("Not enough Mana");
                Thread.Sleep(1000);
            }
            else
            {
                Random chance = new Random();
                int attackchance = chance.Next(1, 5);

                if (attackchance == 1)
                {
                    Random chance2 = new Random();
                    int attackchance2 = chance2.Next(80, 100);
                    Console.WriteLine("You make {0} damage on your enemy",attackchance2);
                    enemy = enemy - attackchance2;
                    Mana = Mana - 75;
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("You Miss !");
                    Thread.Sleep(1000);
                }
            }
        }
        public void BoneCrusher(ref int enemy, ref int Mana)        //this method is the same method with another attack
        {
            if (Mana < 150)
            {
                Console.WriteLine("Not enough Mana");
                Thread.Sleep(1000);
            }
            else
            {
                Random chance = new Random();
                int attackchance = chance.Next(1, 7);

                if ( attackchance == 1)
                {
                    Random chance2 = new Random();
                    int Attackchance2 = chance2.Next(400, 500);
                    Console.WriteLine("You make {0} damage on your enemy by using Bone Crusher",Attackchance2);
                    enemy = enemy - Attackchance2;
                    Mana = Mana - 150;
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Miss using Bone Crusher!");
                    Thread.Sleep(1000);
                }
            }
        }

        public void Heal(ref int Health, ref int Mana)      // same as the another Heal method
        {
            Random chance = new Random();
            int healchance = chance.Next(50, 60);
            if (Mana < 50)
            {
                Console.WriteLine("Not enough Mana for Heal");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Succesfuly healing {0} point", healchance);
                Health = Health + healchance;
                Mana = Mana - 50;
                Thread.Sleep(1000);
            }
        }

        public void Selected()      // and also this method is same with another
        {
            Console.WriteLine("Orc was Selected for your Hero");
            Console.WriteLine("Hp {0} \t Mp {1}", Health, Mana);
        }
    }
}
