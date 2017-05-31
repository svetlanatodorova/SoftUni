using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());
            var sum = 0;
            var count = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    sum = sum + (i * j * 3);
                    count++;
                    if (sum >= maxSum)
                    {
                        Console.WriteLine("{0} combinations\nSum: {1} >= {2}", count, sum, maxSum);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations\nSum: {1}", count, sum);
        }
    }
}
