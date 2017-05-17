using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n > 1)
            {
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());
                var c = int.Parse(Console.ReadLine());
                var d = int.Parse(Console.ReadLine());
                var sum1 = a + b;
                var sum2 = c + d;
                var diff = Math.Abs(sum2 - sum1);
                var maxDiff = diff;
                for (int i = 0; i < (2 * n - 4) / 2; i++)
                {
                    var e = int.Parse(Console.ReadLine());
                    var f = int.Parse(Console.ReadLine());
                    sum1 = sum2;
                    sum2 = e + f;
                    if (sum1 != sum2 && Math.Abs(sum2 - sum1) > maxDiff) maxDiff = Math.Abs(sum1 - sum2);

                }
                if (maxDiff != 0) Console.WriteLine("No, maxdiff={0}", maxDiff);
                else Console.WriteLine("Yes, value={0}", sum1);
            }
            else if (n == 1)
            {
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());
                Console.WriteLine("Yes, value={0}", a + b);
            }
        }
    }
}
