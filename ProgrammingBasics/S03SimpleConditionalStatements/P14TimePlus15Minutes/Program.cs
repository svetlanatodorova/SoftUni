using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 15;
            if (minutes < 60)
            {
                Console.WriteLine(hour + ":" + minutes);
            }
            else
            {
                minutes = minutes - 60;
                hour++;
                if (hour == 24) hour = 0;
                Console.WriteLine(hour + ":" + minutes.ToString("D2"));
            }
        }
    }
}
