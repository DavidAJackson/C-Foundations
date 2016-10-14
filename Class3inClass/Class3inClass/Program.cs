using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3inClass
{
    class Program
    {
        static void Main()
        {
            Console.Write("input number: ");
            string userinput = Console.ReadLine();
            int xval = int.Parse(userinput);
            int xcalc = (int)((5 * xval * xval) + 6);
            Console.WriteLine("the answer is {0}", xcalc);
            Console.ReadLine();

        }
    }
}
