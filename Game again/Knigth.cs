using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game_again
{
    class Knigth : Indicators
    {
        public Knigth()     //Knight indicators
        {
            Health = 650;
            Mana = 450;
            Name = "Knigth";
            Special_Attack = "Broadsword";
        }

        public void Attack( ref int enemy ,ref int Mana)        //this method will processing the Attack and call the enemy and the mana
        {
            if (Mana < 10)      //if mana less from 10 the action will not play
            {
                Console.WriteLine("Your Mana is enough !");
                Thread.Sleep(1000);
            }
            else
            {
                Random chance = new Random();

                int attackchance = chance.Next(1, 4);     //this attack chance within 45 and 80 randomly
                if (attackchance != 1 )
                {
                    Random chance2 = new Random();
                    int attackchance2 = chance.Next(45, 80);
                    Console.WriteLine("You make {0} damage on your enemy", attackchance2);
                    enemy = enemy - attackchance2;
                    Mana = Mana - 10;       //the attack is use mana 10 point
                    Thread.Sleep(1000);

                }
                else
                {
                    Console.WriteLine("That Miss ! Not make damage on your enemy");     //this section is if the attack is miss
                    Thread.Sleep(1000);
                }
            }
        }

        public void Heal( ref int Health, ref int Mana)        //Heal method is ref the Health and Mana because both of them will use in this method
        {
            Random chance = new Random();
            int healchance = chance.Next(35, 70);       // same as also we know is the chance of the heal between 35 and 70 point

            if (Mana < 20)      // if the mana is less from 20 point, the heal isn't work
            {
                Console.WriteLine("Not enough Mana for healing ");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("You've been healing {0}",healchance);
                Health = Health + healchance;
                Mana = Mana - 20;
                Thread.Sleep(1000);
            }
        }
        public void Broadsword( ref int enemy, ref int Mana)        //Broadsowrd method is same as the Attack method
        {
            if (Mana < 50)
            {
                Console.WriteLine("Not enough Mana for Broadsword");
                Thread.Sleep(1000);
            }
            else
            {
                Random chance = new Random();
                int attackchance = chance.Next(1, 10);

                if (attackchance == 1)
                {
                    Random chance2 = new Random();
                    int attackchance2 = chance2.Next(100, 200);
                    Console.WriteLine("You make {0} damage on your enemy with Broadsword !!",attackchance2);
                    enemy = enemy - attackchance2;
                    Mana = Mana - 50;
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("You Miss !");
                    Thread.Sleep(1000);
                }
            }
        }
        public void Selected()      //this section, come when the hero are selected
        {
            Console.WriteLine("Knigth has selected for your hero");     
            Console.WriteLine("Hp {0} \t Mp {1}", Health, Mana);        //that showing the indicators of health and mana of the hero 
        }
    }
}
