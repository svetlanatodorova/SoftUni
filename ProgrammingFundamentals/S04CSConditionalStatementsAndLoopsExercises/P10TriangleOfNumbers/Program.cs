using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                Console.Write(i);
                for (int j = 2; j < i + 1; j++)
                {
                    Console.Write(" " + i);
                }
                Console.WriteLine();
            }
        }
    }
}
