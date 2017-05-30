using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());
            var price = 0;
            if ((day == "weekday" && age >= 0 && age <= 18) || (day == "weekday" && age > 64 && age <= 122) || (day == "holiday" && age > 18 && age <= 64))
                price = 12;
            if ((day == "weekend" && age >= 0 && age <= 18) || (day == "weekend" && age > 64 && age <= 122))
                price = 15;
            if (day == "weekday" && age > 18 && age <= 64) price = 18;
            if (day == "weekend" && age > 18 && age <= 64) price = 20;
            if (day == "holiday" && age >= 0 && age <= 18) price = 5;
            if (day == "holiday" && age > 64 && age <= 122) price = 10;
            if (price == 0) Console.WriteLine("Error!"); else Console.WriteLine("{0}$", price);
        }
    }
}
