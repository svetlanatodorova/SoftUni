using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            string result = "";
            if ((x > h && x < 2 * h && y >= h && y < 4 * h) || (x > 0 && x < 3 * h && y > 0 && y < h)) result = "inside";
            else if (((y < 0 || y > 4 * h || x < 0 || x > 3 * h)) || ((x > 0 && x < h && y > h && y <= 4 * h)) || ((x > 2 * h && x < 3 * h && y > h && y < 4 * h))) result = "outside";
            else if ((x == 0 && y > h) || (y == 4 * h && x < h) || (y == 4 * h && x > 2 * h) || (x == 3 * h && y > h)) result = "outside";
            else result = "border";
            Console.WriteLine(result);
        }
    }
}
