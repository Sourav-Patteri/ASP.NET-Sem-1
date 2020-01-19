using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
           const double pi = 3.14159;
            Console.WriteLine("Please enter the radius of the circle");
            float radius = float.Parse(Console.ReadLine());
            double AreaOfCircle = pi * radius * radius;
            Console.WriteLine("Area of Circle = " + AreaOfCircle);
            //Console.ReadLine();


        }
    }
}
