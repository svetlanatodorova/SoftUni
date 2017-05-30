using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bpm = int.Parse(Console.ReadLine());
            var numberOfBeats = int.Parse(Console.ReadLine());
            var bars = Math.Round(((double)numberOfBeats / 4.0),1);
            var allminutes = numberOfBeats / (double)bpm * 60.0;
            var minutes = allminutes / 60;
            var seconds = allminutes % 60;
            Console.WriteLine("{0} bars - {1}m {2}s", bars, Math.Truncate(minutes), Math.Truncate(seconds));
        }
    }
}
