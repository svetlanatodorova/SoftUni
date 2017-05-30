using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCaloriesAmount = 0;
            var n = int.Parse(Console.ReadLine());
            var ingredient = "";
            for (int i = 1; i <= n; i++)
            {
                ingredient = Console.ReadLine().ToLower();
                if (ingredient == "cheese")
                {
                    totalCaloriesAmount = totalCaloriesAmount + 500;
                }
                else if (ingredient == "tomato sauce")
                {
                    totalCaloriesAmount = totalCaloriesAmount + 150;
                }
                else if (ingredient == "salami")
                {
                    totalCaloriesAmount = totalCaloriesAmount + 600;
                }
                else if (ingredient == "pepper")
                {
                    totalCaloriesAmount = totalCaloriesAmount + 50;
                }
                else                {
                    totalCaloriesAmount = totalCaloriesAmount + 0;
                }


            }
            Console.WriteLine($"Total calories: {totalCaloriesAmount}");
        }
    }
}
