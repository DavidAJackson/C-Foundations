using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
            {
                int iX;
                int iY;
                iX = 15321;
                while (iX != 0)
                {
                    iY = iX % 10;
                    Console.Write(iY);
                    iX /= 10;
                }
                Console.WriteLine(); } }
    }
    }
}
