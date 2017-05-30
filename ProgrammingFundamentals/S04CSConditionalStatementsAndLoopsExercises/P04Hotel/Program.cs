using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            var nightCount = byte.Parse(Console.ReadLine());
            var studioPrice = 0.00;
            var doublePrice = 0.00;
            var suitePrice = 0.00;
            if (month == "may" || month == "october")
            {
                studioPrice = (nightCount > 7) ? 0.95 * 50.0 : 50.00;
                doublePrice = 65.00;
                suitePrice = 75.00;
            }
            else if (month == "june" || month == "september")
            {
                studioPrice = 60.00;
                doublePrice = (nightCount > 14) ? 0.90 * 72.00 : 72.00;
                suitePrice = 82.00;
            }
            else if (month == "july" || month == "august" || month == "december")
            {
                studioPrice = 68.00;
                doublePrice = 77.00;
                suitePrice = (nightCount > 14) ? 0.85 * 89.00 : 89.00;
            }

            if ((month == "september" || month == "october") && (nightCount > 7))
            {
                Console.WriteLine("Studio: {0:f2} lv.", studioPrice * (nightCount - 1));
                Console.WriteLine("Double: {0:f2} lv.", doublePrice * nightCount);
                Console.WriteLine("Suite: {0:f2} lv.", suitePrice * nightCount);
            }
            else
            {
                Console.WriteLine("Studio: {0:f2} lv.", studioPrice * nightCount);
                Console.WriteLine("Double: {0:f2} lv.", doublePrice * nightCount);
                Console.WriteLine("Suite: {0:f2} lv.", suitePrice * nightCount);
            }
        }
    }
}
