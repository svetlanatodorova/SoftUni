using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            string package = Console.ReadLine();
            double price = 0.00;
            string hallName = "";
            if (groupSize <=50)
            {
                price = 2500.00;
                hallName = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                price = 5000.00;
                hallName = "Terrace";
            }
            else if (groupSize <= 120)
            {
                price = 7500.00;
                hallName = "Great Hall";
            }

            if (package == "Normal") price = 0.95 * (price + 500.00);
            else if (package == "Gold") price = 0.90 * (price + 750.00);
            else if (package == "Platinum") price = 0.85 * (price + 1000.00);


            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {(price / groupSize):f2}$");
        }
    }
}
