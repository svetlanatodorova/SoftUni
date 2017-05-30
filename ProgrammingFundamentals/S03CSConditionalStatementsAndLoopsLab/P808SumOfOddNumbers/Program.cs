using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P808SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var nextOddNumber = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(nextOddNumber);
                sum = sum + nextOddNumber;
                nextOddNumber = nextOddNumber + 2;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
