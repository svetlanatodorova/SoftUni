using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = double.Parse(Console.ReadLine());
            var fahrenheit = c * 9 / 5 + 32;
            Console.WriteLine(Math.Round(fahrenheit, 2));
        }
    }
}
