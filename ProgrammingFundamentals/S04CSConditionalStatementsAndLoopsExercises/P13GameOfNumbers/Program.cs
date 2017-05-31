using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            var sum = 0;
            var count = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = m; j >= n; j--)
                {
                    sum = i + j;
                    count++;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine("Number found! {0} + {1} = {2}", j, i, magicNumber);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations - neither equals {1}", count, magicNumber);
        }
    }
}
