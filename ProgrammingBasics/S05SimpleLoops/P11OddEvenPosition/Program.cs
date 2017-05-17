using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            if (n > 1)
            {
                var oddSum = double.Parse(Console.ReadLine());
                var oddMin = oddSum;
                var oddMax = oddSum;
                var evenSum = double.Parse(Console.ReadLine());
                var evenMin = evenSum;
                var evenMax = evenSum;
                for (int i = 1; i < n - 1; i++)
                {
                    var nextNum = double.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        evenSum = evenSum + nextNum;
                        if (nextNum > evenMax)
                        {
                            evenMax = nextNum;
                        }
                        else if (nextNum < evenMin)
                        {
                            evenMin = nextNum;
                        }
                    }
                    else
                    {
                        oddSum = oddSum + nextNum;
                        if (nextNum > oddMax)
                        {
                            oddMax = nextNum;
                        }
                        else if (nextNum < oddMin)
                        {
                            oddMin = nextNum;
                        }
                    }
                }
                Console.WriteLine("OddSum={0}", oddSum);
                Console.WriteLine("OddMin={0}", oddMin);
                Console.WriteLine("OddMax={0}", oddMax);
                Console.WriteLine("EvenSum={0}", evenSum);
                Console.WriteLine("EvenMin={0}", evenMin);
                Console.WriteLine("EvenMax={0}", evenMax);
            }
            else if (n == 0)
            {
                Console.WriteLine("OddSum=0");
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            else if (n == 1)
            {
                var num = double.Parse(Console.ReadLine());
                {
                    Console.WriteLine("OddSum={0}", num);
                    Console.WriteLine("OddMin={0}", num);
                    Console.WriteLine("OddMax={0}", num);
                    Console.WriteLine("EvenSum=0");
                    Console.WriteLine("EvenMin=No");
                    Console.WriteLine("EvenMax=No");
                }
            }
        }
    }
}
