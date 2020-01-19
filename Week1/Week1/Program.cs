using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sourav";
            //int num1, num2;
           // Console.WriteLine("Hey Did you know "+name+" rocks?");
           // Console.WriteLine("Hey {0} Did you know "  ,name  +" rocks?");
           //var ans = Console.ReadLine();
            //Console.WriteLine(ans);
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation");
            var op = Console.ReadLine();
            if (op == "+")
            {
                int result = num1 + num2;
                Console.WriteLine(result);
            }
            if (op == "-")
            {
                int result = num1 - num2;
                Console.WriteLine(result);
            }
            
            
        }
    }
}
