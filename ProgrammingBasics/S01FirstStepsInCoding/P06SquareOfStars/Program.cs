using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var n = int.Parse(Console.ReadLine());
                if (n < 2 || n > 100) return;

                for (int r = 1; r <= n; r++)
                {
                    for (int c = 1; c <= n; c++)
                    {
                        if (r == 1 || r == n || c == 1 || c == n)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine("");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
