using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambler
{
    public class GamblerEx
    {
        public void Display()
        {
            int Bet = 1;
            int Money = 100;
            Random bet_num = new Random();
            int check = bet_num.Next(0, 100);
            Console.WriteLine("Started:");
            Console.WriteLine(check);
            if (Bet == check)
            {
                Console.WriteLine("You Win");
            }
            else
            {
                Console.Write("Loss");
            }
        }
    }
}
