using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main()
        {
            // main part of the homework
            Console.Write("Enter a number of successive factorials to display: ");
            string input = Console.ReadLine();
            int x = int.Parse(input);
            
           
                int factorial = 1;
                for (int i = 1; i <= x; i++)
                {
                    factorial *= i;
                    Console.WriteLine("{0}!     =     {1}", i, factorial);
                }

            // end of main part of homework
            // start of optional 1
            int[] numbers = new int[] { 5, -2, 100, 12, 4, -5 };
           int min = numbers.Min();
           int max = numbers.Max();

           Console.WriteLine("The min is {0} and the max is {1}", min, max);
            // end of optional 1
            // start of optional 2

            Console.Write("enter an integer to see if it is in the array: ");
            string input2 = Console.ReadLine();
            int xx = int.Parse(input2);
            if (numbers.Contains(xx))
                {
                Console.WriteLine("Yes it is");
            }
            else
            {
                Console.WriteLine("No it is not");
            }
            // end of optional 2
            // start of optional 3

            int temp = 0;
            for (int write = 0; write < numbers.Length; write++)
            {
                for (int sort = 0; sort < numbers.Length - 1; sort++)
                {
                    if (numbers[sort] > numbers [sort + 1])
                    {
                        temp = numbers[sort + 1];
                        numbers[sort + 1] = numbers[sort];
                        numbers[sort] = temp;
                    }
                }
            }

            for (int k = 0; k < numbers.Length; k++)
            {
                Console.WriteLine(numbers[k] + " ");
            }
            // end of optional 3


            Console.ReadLine();
        }
    }
}
