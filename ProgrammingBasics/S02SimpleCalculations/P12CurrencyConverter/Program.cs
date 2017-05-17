using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = double.Parse(Console.ReadLine());
            string ent = Console.ReadLine();
            string exit = Console.ReadLine();
            const double usd = 1.79549;
            const double eur = 1.95583;
            const double gbp = 2.53405;

            if (ent == "BGN" && exit == "USD")
                Console.WriteLine(Math.Round(sum / usd, 2) + " USD");
            else if (ent == "BGN" && exit == "EUR")
                Console.WriteLine(Math.Round(sum / eur, 2) + " EUR");
            else if (ent == "BGN" && exit == "GBP")
                Console.WriteLine(Math.Round(sum / gbp, 2) + " GBP");
            else if (ent == "USD" && exit == "BGN")
                Console.WriteLine(Math.Round(sum * usd, 2) + " BGN");
            else if (ent == "USD" && exit == "EUR")
                Console.WriteLine(Math.Round(sum * usd / eur, 2) + " EUR");
            else if (ent == "USD" && exit == "GBP")
                Console.WriteLine(Math.Round(sum * usd / gbp, 2) + " GBP");
            else if (ent == "EUR" && exit == "BGN")
                Console.WriteLine(Math.Round(sum * eur, 2) + " BGN");
            else if (ent == "EUR" && exit == "USD")
                Console.WriteLine(Math.Round(sum * eur / usd, 2) + " USD");
            else if (ent == "EUR" && exit == "GBP")
                Console.WriteLine(Math.Round(sum * eur / gbp, 2) + " GBP");
            else if (ent == "GBP" && exit == "BGN")
                Console.WriteLine(Math.Round(sum * gbp, 2) + " BGN");
            else if (ent == "GBP" && exit == "USD")
                Console.WriteLine(Math.Round(sum * gbp / usd, 2) + " USD");
            else if (ent == "GBP" && exit == "EUR")
                Console.WriteLine(Math.Round(sum * gbp / eur, 2) + " EUR");
        }
    }
}
