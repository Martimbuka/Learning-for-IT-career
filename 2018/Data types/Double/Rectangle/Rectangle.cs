using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double P = a * 2 + b * 2;
            double S = a * b;
            decimal diagonal = (decimal) Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine(P);
            Console.WriteLine(S);
            Console.WriteLine(diagonal);
        }
    }
}
