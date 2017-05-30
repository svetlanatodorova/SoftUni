using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var result = (double)width * (double)height / 1000000.0;
            Console.WriteLine("{0}x{1} => {2}MP", width, height, Math.Round((result),1));
        }
    }
}
