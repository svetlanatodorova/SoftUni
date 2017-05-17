using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16NumberFrom0To100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            int a1 = a / 10;
            int a2 = a % 10;
            string dec = "";
            string units = "";

            if (a1 == 1) dec = "ten";
            else if (a1 == 2) dec = "twenty";
            else if (a1 == 3) dec = "thirty";
            else if (a1 == 4) dec = "fourty"; //forty
            else if (a1 == 5) dec = "fifty";
            else if (a1 == 6) dec = "sixty";
            else if (a1 == 7) dec = "seventy";
            else if (a1 == 8) dec = "eighty";
            else if (a1 == 9) dec = "ninety";
            else if (a1 == 10) dec = "one hundred";


            if (a2 == 1) units = "one";
            else if (a2 == 2) units = "two";
            else if (a2 == 3) units = "three";
            else if (a2 == 4) units = "four";
            else if (a2 == 5) units = "five";
            else if (a2 == 6) units = "six";
            else if (a2 == 7) units = "seven";
            else if (a2 == 8) units = "eight";
            else if (a2 == 9) units = "nine";


            if (a < 0 || a > 100) Console.WriteLine("invalid number");
            else if (a == 0) Console.WriteLine("zero");
            else if (a1 == 0) Console.WriteLine(units);
            else if (a2 == 0) Console.WriteLine(dec);
            else if (a == 11) Console.WriteLine("eleven");
            else if (a == 12) Console.WriteLine("twelve");
            else if (a == 13) Console.WriteLine("thirteen");
            else if (a == 14) Console.WriteLine("fourteen");
            else if (a == 15) Console.WriteLine("fifteen");
            else if (a == 16) Console.WriteLine("sixteen");
            else if (a == 17) Console.WriteLine("seventeen");
            else if (a == 18) Console.WriteLine("eighteen");
            else if (a == 19) Console.WriteLine("nineteen");
            else Console.WriteLine(dec + " " + units);
        }
    }
}
