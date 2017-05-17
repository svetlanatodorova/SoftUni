using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = decimal.Parse(Console.ReadLine());
                var b = decimal.Parse(Console.ReadLine());
                var c = a * b;
                Console.WriteLine(c);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
