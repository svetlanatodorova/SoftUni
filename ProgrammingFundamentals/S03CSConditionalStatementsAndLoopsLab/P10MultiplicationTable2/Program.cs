using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10MultiplicationTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());
            if (multiplier < 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", number, i, number * i);
                }
            }
            else Console.WriteLine("{0} X {1} = {2}", number, multiplier, number * multiplier);
        }
    }
}
