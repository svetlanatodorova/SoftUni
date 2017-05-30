using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var maxNum = 0;
            var minNum = 0;

            if (number1 > number2)
            {
                maxNum = number1;
                minNum = number2;
            }
            else
            {
                maxNum = number2;
                minNum = number1;
            }

            for (int i = minNum; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
