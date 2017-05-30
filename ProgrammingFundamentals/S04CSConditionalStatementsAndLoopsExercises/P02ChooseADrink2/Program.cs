using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ChooseADrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double totalPrice = 0.00;
            if (profession == "Athlete") totalPrice = 0.70;
            else if (profession == "Businessman" || profession == "Businesswoman") totalPrice = 1.00;
            else if (profession == "SoftUni Student") totalPrice = 1.70;
            else totalPrice = 1.20;
            Console.WriteLine($"The {profession} has to pay {(totalPrice * (double)quantity):f2}.");
        }
    }
}
