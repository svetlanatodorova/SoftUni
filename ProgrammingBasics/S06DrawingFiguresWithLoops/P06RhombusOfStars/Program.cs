using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //Top part
            for (int row = 1; row <= n; row++)
            {
                for (int i = 0; i < n - row; i++)
                    Console.Write(" ");
                Console.Write("*");

                for (int i = 0; i < row - 1; i++)
                    Console.Write(" *");
                Console.WriteLine();
            }
            //Down part
            for (int row = 1; row <= (n - 1); row++)
            {
                for (int i = 0; i < row; i++)
                    Console.Write(" ");
                Console.Write("*");

                for (int i = 0; i < (n - row - 1); i++)
                    Console.Write(" *");
                Console.WriteLine();
            }
        }
    }
}
