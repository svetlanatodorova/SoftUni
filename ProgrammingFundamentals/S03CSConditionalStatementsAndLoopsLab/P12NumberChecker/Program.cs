﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = double.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
