using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game_again
{
    class Choice
    {
        // this class will handle when you chosing the Hero
        public int Chosing()
        {
            Orc orc = new Orc();
            Knigth knigth = new Knigth();

            //Starting 
            Console.WriteLine("------Welcome to Game-------");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            //Chosing section
            Console.WriteLine("============================");
            Console.WriteLine("==     Hall of Hero       ==");
            Console.WriteLine("============================");
            Console.WriteLine("");
            Thread.Sleep(1000);

            Console.WriteLine("----------------------------");
            Console.WriteLine("1. {0}",orc.Name);
            Console.WriteLine("2. {0}",knigth.Name);
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.Write("Enter your Hero ");
            int characther = int.Parse(Console.ReadLine());
            return characther;
        }
    }
}
