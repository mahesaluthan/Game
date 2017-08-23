using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_again
{
    class Program
    {
        static void Main(string[] args)
        {
            Choice milih = new Choice();
            battleground perang = new battleground();
            int character = milih.Chosing();
            perang.Battle(character);
            Console.ReadKey();
        }
    }
}
