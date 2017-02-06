using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            int Length = 25;
            int Width = 42;
            int Area = Length * Width;
            int yardArea = Area / 9;
            int carpetCost = yardArea / 9;
            Console.WriteLine("the cost of the carpets is {0} pre square yard", carpetCost);
            

        }
    }
}
