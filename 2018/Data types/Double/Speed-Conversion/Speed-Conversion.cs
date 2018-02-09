using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());
            var ms = distance / (hours * 3600 + minutes * 60 + seconds);
            var kmh = (distance / 1000) / (hours + minutes / 60 + seconds / 3600);
            var mph = (distance / 1609) / (hours + minutes / 60 + seconds / 3600);
            Console.WriteLine(ms);
            Console.WriteLine(kmh);
            Console.WriteLine(mph);
        }
    }
}
