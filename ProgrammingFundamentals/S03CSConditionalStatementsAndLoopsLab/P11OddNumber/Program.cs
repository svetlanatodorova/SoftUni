using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (Math.Abs(number % 2) == 1) Console.WriteLine("The number is: {0}", Math.Abs(number));
            else
            {
                do
                {
                    Console.WriteLine("Please write an odd number.");
                    number = int.Parse(Console.ReadLine());
                }
                while (Math.Abs(number % 2) != 1);
                Console.WriteLine("The number is: {0}", Math.Abs(number));
            }
        }
    }
}
