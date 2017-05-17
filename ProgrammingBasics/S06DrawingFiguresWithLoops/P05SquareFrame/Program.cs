using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("+");
                return;
            }
            Console.Write("+");
            for (var r = 0; r < n - 2; r++)
                Console.Write(" -");
            Console.WriteLine(" +");
            for (var c = 0; c < n - 2; c++)
            {
                Console.Write("|");
                for (var k = 0; k < n - 2; k++)
                    Console.Write(" -");
                Console.WriteLine(" |");
            }
            Console.Write("+");
            for (var r = 0; r < n - 2; r++)
                Console.Write(" -");
            Console.WriteLine(" +");
        }
    }
}
