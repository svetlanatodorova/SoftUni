using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            var holidays = double.Parse(Console.ReadLine());
            var weekendsHome = double.Parse(Console.ReadLine());
            var allGames = 0.0;
            allGames = (2.0 / 3.0 * holidays + 3.0 / 4.0 * (48.0 - weekendsHome) + weekendsHome);
            if (year == "leap") allGames = allGames * 1.15;
            Console.WriteLine(Math.Truncate(allGames));
        }
    }
}
