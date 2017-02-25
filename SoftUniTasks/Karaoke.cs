using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
   public class Racer
    {
        public string Name { get; set; }
        public double Fuel { get; set; }
        public long finished = -1; 
        public Racer(string name, double fuel)
        {
            this.Name = name;
            this.Fuel = fuel;

        }
    }

    class Program
    {
        static void Main()
        {
            var participants = Console.ReadLine()
                .Split(new char[] { ' ' }, 
                 StringSplitOptions.RemoveEmptyEntries);

            var racers = new List<Racer>();

            foreach (var part in participants)
            {
                if (!racers.Any(r => r.Name == part))
                {
                    racers.Add(new Racer(part, part[0]));
                }
                
            }

            var track = Console.ReadLine()
                .Split(new char[] { ' ' },
                 StringSplitOptions.RemoveEmptyEntries).Select(double.Parse)
                .ToList();

            var checkPionts = Console.ReadLine()
                .Split(new char[] { ' ' }, 
                 StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();



            for (int i = 0; i < track.Count; i++)
            {
                for (int j = 0; j < racers.Count; j++)
                {
                    if (checkPionts.Any(ch => ch == i))
                    {
                        racers[j].Fuel += track[i];
                    }
                    else if (racers[j].Fuel<=track[i])
                    {
                         racers[j].finished = i;
                    }
                    else
                    {
                        racers[j].Fuel -= track[i];
                    }
                }        
            }
            foreach (var item in racers)
            {
                if (item.finished !=-1)
                {
                    Console.WriteLine($"{item.Name} - reached {item.finished}");
                }
                else Console.WriteLine("{0} - fuel left {1:f2}", item.Name, item.Fuel);
            }
        }
    }
}
