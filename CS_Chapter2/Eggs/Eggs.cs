using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken1 = 4;
            int chicken2 = 6;
            int chicken3 = 8;
            int chicken4 = 3;
            int totalEggs = (chicken1 + chicken2 + chicken3 + chicken4);
            int dozen = totalEggs / 12;
            int remainderEgg = (totalEggs % 12);
            string name1 = "dozen";

            Console.WriteLine("the amount of eggs for this mouth is {0}. in all we got {1} dozen and {2} eggs this mouth", totalEggs, dozen, remainderEgg);



        }
    }
}
