using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of eggs for chicken #1 : ");
            int chicken1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of eggs for chicken #2 : ");
            int chicken2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of eggs for chicken #3 : ");
            int chicken3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of eggs for chicken #4 : ");
            int chicken4 = Convert.ToInt32(Console.ReadLine());
            int totalEggs = (chicken1 + chicken2 + chicken3 + chicken4);
            int dozen = totalEggs / 12;
            int remainderEgg = (totalEggs % 12);
            string name1 = "dozen";

            Console.WriteLine("the amount of eggs for this mouth is {0}. in all we got {1} {2} and {3} eggs this mouth", totalEggs, dozen, name1, remainderEgg);


        }
    }
}
