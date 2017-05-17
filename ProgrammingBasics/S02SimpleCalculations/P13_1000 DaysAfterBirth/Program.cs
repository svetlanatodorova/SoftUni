using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_1000_DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateStr = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateStr, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime dateafter = date.AddDays(999);
            Console.WriteLine(dateafter.ToString("dd-MM-yyyy"));
        }
    }
}
