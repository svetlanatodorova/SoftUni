using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03LatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var letter = 'a'; letter <= 'z'; letter++)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine();
        }
    }
}
