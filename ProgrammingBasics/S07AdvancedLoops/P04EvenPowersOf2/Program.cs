﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n / 2; i++)
            {
                Console.WriteLine(1 << (2 * i));
            }
        }
    }
}
