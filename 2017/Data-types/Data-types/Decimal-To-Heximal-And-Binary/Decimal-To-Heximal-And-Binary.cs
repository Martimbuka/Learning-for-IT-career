using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_To_Heximal_And_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decValue = int.Parse(Console.ReadLine());
            string hexValue = Convert.ToString(decValue, 16).ToUpper();
            string binValue = Convert.ToString(decValue, 2);
            Console.WriteLine(hexValue);
            Console.WriteLine(binValue);
        }
    }
}
