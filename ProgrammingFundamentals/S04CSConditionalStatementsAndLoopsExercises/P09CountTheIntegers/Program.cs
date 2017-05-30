using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var countNumbers = 0;
            var input = 0;
            try
            {
                while (true)
                {
                    input = int.Parse(Console.ReadLine());
                    countNumbers ++;
                }
            }
            catch
            {
                Console.WriteLine(countNumbers);
            }
        }
    }
}
