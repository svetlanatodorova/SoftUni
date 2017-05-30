using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            const double km = 1.60934;
            var miles = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", km * miles);
        }
    }
}
