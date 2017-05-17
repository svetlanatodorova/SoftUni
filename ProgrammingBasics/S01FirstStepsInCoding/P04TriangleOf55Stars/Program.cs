using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            for (int i = 1; i <= 10; i++)
            {
                a = a + "*";
                Console.WriteLine(a);
            }
        }
    }
}
