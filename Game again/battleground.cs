using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Game_again
{
    class battleground
    {
        public void Battle (int characther)
        {
            //Choice milih = new Choice();
            //milih.Chosing();
            //Console.Clear();

            Orc orc = new Orc();
            Knigth knigth = new Knigth();
            Monsters m = new Monsters();

            int[] player = new int[2];
            int[] enemy = new int[2];
            string[] voice = new string[2];

            if (characther == 1)
            {
                player[0] = orc.Health;
                player[1] = orc.Mana;
                voice[0] = orc.Name;
                voice[1] = orc.Special_Attack;
            }
            else if (characther == 2)
            {
                player[0] = knigth.Health;
                player[1] = knigth.Mana;
                voice[0] = knigth.Name;
                voice[1] = knigth.Special_Attack;
            }

            enemy[0] = m.Health;
            enemy[1] = m.Mana;

            while (enemy[0] > 0 && player[0] > 0 )
            {
                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine("=-------Battleground---------=");
                Console.WriteLine("==============================");
                Console.WriteLine("---------Indicators-----------");
                Console.WriteLine("{0} \t\t Monsters",voice[0]);
                Console.WriteLine("Hp {0} \t\t Hp {1}", player[0], enemy[0]);
                Console.WriteLine("Mp {0} \t\t Mp {1}", player[1], enemy[1]);
                Console.WriteLine("------------------------------");
                Console.WriteLine("");

                Console.WriteLine("Your Turn");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. {0}", voice[1]);
                Console.WriteLine("3. Heal");
                Console.WriteLine("4. Mana Heal");
                Console.Write("What your command ");
                int action = int.Parse(Console.ReadLine());
                Thread.Sleep(1000);

                if (action == 1)
                {
                    if (characther == 1)
                    {
                        orc.Attack(ref enemy[0], ref player[1]);
                    }
                    else if (characther == 2)
                    {
                        knigth.Attack(ref enemy[0], ref player[1]);
                    }
                }
                else if (action == 2)
                {
                    if (characther == 1)
                    {
                        orc.BoneCrusher(ref enemy[0], ref player[1]);
                    }
                    else if (characther == 2)
                    {
                        knigth.Broadsword(ref enemy[0], ref player[1]);
                    }
                }
                else if (action == 3)
                {
                    if (characther == 1)
                    {
                        orc.Heal(ref player[0], ref player[1]);
                    }
                    else if (characther == 2)
                    {
                        knigth.Heal(ref player[0], ref player[1]);
                    }
                }
                else if (action == 4)
                {
                    Random chance = new Random();
                    int manaheal = chance.Next(50, 100);
                    player[1] = player[1] + manaheal;
                    Console.WriteLine("Mana healing succesful {0}",manaheal);
                }


                Console.WriteLine("");
                Console.WriteLine("Monster Turn");
                Thread.Sleep(1000);
                Console.WriteLine("");
                m.attack(ref enemy[1], ref player[0]);
                Console.ReadLine();
            }
            Console.Clear();
            if (enemy[0] <= 0)
            {
                Console.WriteLine("The victory in yours");
            }
            else
            {
                Console.WriteLine("You are dead");
            } 
        }
    }
}
