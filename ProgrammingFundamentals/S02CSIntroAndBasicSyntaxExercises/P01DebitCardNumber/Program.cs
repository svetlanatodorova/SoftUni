using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var fourthNumber = int.Parse(Console.ReadLine());
            Console.Write("{0:D4} ", firstNumber);
            Console.Write("{0:D4} ", secondNumber);
            Console.Write("{0:D4} " , thirdNumber);
            Console.WriteLine("{0:D4}", fourthNumber);
        }
    }
}
