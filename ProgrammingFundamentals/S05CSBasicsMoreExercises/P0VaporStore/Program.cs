using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var nextGame = "";
            var price = 0.00;
            var balance = double.Parse(Console.ReadLine());
            var currentBalance = balance;

            do
            {
                var notFound = 0;
                nextGame = Console.ReadLine();
                if (nextGame == "Game Time") break;
                else if (nextGame == "OutFall 4") price = 39.99;
                else if (nextGame == "CS: OG") price = 15.99;
                else if (nextGame == "Zplinter Zell") price = 19.99;
                else if (nextGame == "Honored 2") price = 59.99;
                else if (nextGame == "RoverWatch") price = 29.99;
                else if (nextGame == "RoverWatch Origins Edition") price = 39.99;
                else
                {
                    Console.WriteLine("Not Found");
                    notFound = 1;
                }
                if (price > currentBalance) Console.WriteLine("Too Expensive");
                else if (price <= currentBalance && notFound == 0)
                {
                    Console.WriteLine($"Bought {nextGame}");
                    currentBalance = currentBalance - price;
                    if (currentBalance == 0)
                    {
                        Console.WriteLine("Out of money!"); return;
                    }
                }
            }
            while (currentBalance > 0);
            Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", balance - currentBalance, currentBalance);
        }
    }
}
