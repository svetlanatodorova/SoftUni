﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int count = 0;
            while (ingredient != "Bake!")
            {
                Console.WriteLine("Adding ingredient {0}.", ingredient);
                ingredient = Console.ReadLine();
                count++;
                if (count > 50) return;
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
