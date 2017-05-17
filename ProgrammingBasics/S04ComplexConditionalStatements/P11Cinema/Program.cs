using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFilm = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            var price = 0.00;
            if (typeFilm == "Premiere") price = 12.00;
            else if (typeFilm == "Normal") price = 7.50;
            else if (typeFilm == "Discount") price = 5.00;
            Console.Write("{0:f2}", (rows * columns * price));
            Console.WriteLine(" leva");
        }
    }
}
