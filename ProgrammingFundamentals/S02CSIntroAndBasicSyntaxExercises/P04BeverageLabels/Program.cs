using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyCont = int.Parse(Console.ReadLine());
            int sugarCont = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars", volume, name, volume / 100.0 * energyCont, volume / 100.0 * sugarCont);
        }
    }
}
