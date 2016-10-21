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
           

            Console.Write("Input a positive number... like an integer number.... a whole number.... like 1, 2, or 4.... keep it small though: ");
            int input = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= input; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("");
            Console.WriteLine("Like, you entered {0} man.....", input);
            Console.WriteLine("Thats like {0}, after you do some math....", factorial);
            Console.ReadLine();

           
        }
    }
}
