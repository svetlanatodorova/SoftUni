using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var maxNum = double.Parse(Console.ReadLine());
            var sumAllNumbers = maxNum;
            for (int i = 0; i < n - 1; i++)
            {
                var k = int.Parse(Console.ReadLine());
                sumAllNumbers = sumAllNumbers + k;
                if (k > maxNum) maxNum = k;
            }

            if (maxNum == sumAllNumbers / 2.0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", maxNum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(2.0 * maxNum - sumAllNumbers));
            }
        }
    }
}
