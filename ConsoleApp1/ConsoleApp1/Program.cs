using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0, j = 0;
        l1: while (i < 2)
            {
                i++;
                while (j < 3)
                {
                    Console.WriteLine("loop\n");
                    goto l1;
                }
            }
            Console.ReadLine();

        }
    }
}
