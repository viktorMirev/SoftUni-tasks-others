using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bees = Console.ReadLine()
                .Split(new[] { ' ', '\t' }
                ,StringSplitOptions
                .RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            var hornets = Console.ReadLine()
                .Split(new[] { ' ', '\t' }
                ,StringSplitOptions
                .RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            long currHornetPow = 0;
            foreach (var h in hornets)
            {
                currHornetPow += h;
            }

            for (int i = 0; i < bees.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }
                long currBeeCount = bees[i];
                if (currHornetPow > currBeeCount)
                {
                    bees[i] = -1;
                }
                else
                {
                    bees[i] -= currHornetPow;
                    currHornetPow -= hornets[0];               
                    hornets.RemoveAt(0);
                }
                               
            }
            if (bees.Any(x => x!=-1 && x>0))
            {             
                Console.WriteLine(string.Join(" ", bees.Where(x => x > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
