using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01X
{
    class Program
    {
        static void Main(string[] args)
        {
            var middleSpaces = 1;
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine($"{new string(' ', i - 1)}{'x'}{new string(' ', n - 2 - (i - 1) * 2)}{'x'}");
            }
            Console.WriteLine($"{new string(' ', (n - 1) / 2)}{'x'}");
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine($"{new string(' ', n / 2 - i)}{'x'}{new string(' ', middleSpaces)}{'x'}");
                middleSpaces += 2;
            }
        }
    }
}
