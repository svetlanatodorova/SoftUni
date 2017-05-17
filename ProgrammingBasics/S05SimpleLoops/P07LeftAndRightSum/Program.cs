using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firstSum = 0;
            for (int i = 0; i < n; i++)
            {
                var x = int.Parse(Console.ReadLine());
                firstSum = firstSum + x;
            }
            var secondSum = 0;
            for (int i = 0; i < n; i++)
            {
                var y = int.Parse(Console.ReadLine());
                secondSum = secondSum + y;
            }
            if (firstSum == secondSum)
            {
                Console.Write("Yes, sum = ");
                Console.WriteLine(firstSum);
            }
            else
            {
                var diff = Math.Abs(firstSum - secondSum);
                {
                    Console.Write("No, diff = ");
                    Console.WriteLine(diff);
                }
            }
        }
    }
}
