using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var damagePesho = int.Parse(Console.ReadLine());
            var damageGosho = int.Parse(Console.ReadLine());
            var lifePesho = 100;
            var lifeGosho = 100;
            var count = 0;
            while ((lifePesho - damageGosho > 0 || lifeGosho - damagePesho > 0) && (lifePesho - damageGosho > 0 && lifeGosho - damagePesho > 0))
            {
                count++;
                if (lifeGosho - damagePesho >= 0)
                {
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", lifeGosho - damagePesho);
                    lifeGosho = lifeGosho - damagePesho;
                }
                    if (count % 3 == 0)
                    {
                        lifePesho += 10;
                        lifeGosho += 10;
                    }
                
                count++;
                if (lifePesho - damageGosho >= 0)
                {
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health", lifePesho - damageGosho);
                    lifePesho = lifePesho - damageGosho;
                }
                if (count % 3 == 0)
                {
                    lifePesho += 10;
                    lifeGosho += 10;
                }

            }
                if (lifePesho > lifeGosho)

                    Console.WriteLine("Gosho won in {0}th round.", count);
                else
                    Console.WriteLine("Pesho won in {0}th round.", count);
        }
    }
}
