using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 195;
            int Hour = minutes / 60;
            int remainderminutes = minutes % 60;
            string name1 = "Minutes";
            string name2 = "Hour";
            Console.WriteLine("it is {0} {1} in hours is {2} {3} and {4} {5}", minutes, name1, Hour, name2, remainderminutes, name1);
        }
    }
}
