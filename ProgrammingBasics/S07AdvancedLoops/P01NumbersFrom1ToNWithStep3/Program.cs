﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01NumbersFrom1ToNWithStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
