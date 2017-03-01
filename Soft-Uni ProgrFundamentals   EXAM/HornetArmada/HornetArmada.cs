using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Legion
    {
        public string Name { get; set; }
        public long Activity { get; set; }
        public Dictionary<string, long> soldierTypes { get; set; }
        public Legion (string name, long activity)
        {
            this.Name = name;
            this.Activity = activity;
            soldierTypes = new Dictionary<string, long>();
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Legion> legions = new Dictionary<string, Legion>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine()
                    .Split(new[] { ' ', ':', '=', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                var lastActivity = int.Parse(command[0]);
                var currName = command[1];
                var currType = command[2];
                var currCount =int.Parse( command[3]);
                if (!legions.ContainsKey(currName))
                {
                    legions.Add(currName, new Legion(currName, lastActivity));
                    legions[currName].soldierTypes.Add(currType, currCount);
                    
                }
                else
                {
                    if (lastActivity>legions[currName].Activity)
                    {
                        legions[currName].Activity = lastActivity;
                    }

                    if (!legions[currName].soldierTypes.ContainsKey(currType))
                    {
                        legions[currName].soldierTypes.Add(currType, currCount);
                    }
                    else
                    {
                        legions[currName].soldierTypes[currType] += currCount;
                    }
                }
            }

            var line = Console.ReadLine();
            if (line.Contains("\\")) 
            {
                var actType = line.Split('\\');
                var act = int.Parse(actType[0]);
                var type = actType[1];
                foreach (var legion in legions.Where(x => x.Value.Activity<act && x.Value.soldierTypes.ContainsKey(type)).OrderByDescending(x => x.Value.soldierTypes[type]))
                {
                    Console.WriteLine($"{legion.Key} -> {legion.Value.soldierTypes[type]}");
                }
            }
            else
            {
                var type = line.Trim();
                foreach (var legion in legions.Where(x => x.Value.soldierTypes.ContainsKey(type)).OrderByDescending(x => x.Value.Activity))
                {
                    Console.WriteLine($"{legion.Value.Activity} : {legion.Key}");
                }
            }
        }
    }
}
