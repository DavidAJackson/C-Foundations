using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main()
        {
            // all the talking should be done in a Mr. T voice

            Console.Write("Input a number of seconds, fool! Make it a big number, but keep it under 2 billion!: ");
            string input = Console.ReadLine();
            int sec = int.Parse(input);
            int min = sec / 60;
            int hrs = min / 60;
            int day = hrs / 24;

            Console.WriteLine("");
            Console.WriteLine("I pity the fact that you put in {0} seconds!", sec);
            Console.WriteLine("Can you even count to {0} minutes?", min);
            Console.WriteLine("That's equal to {0} hours man!", hrs);
            Console.WriteLine("{0} days is a long time to feel the pain!", day);
            Console.ReadLine();

           
        }
    }
}
