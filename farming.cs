using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            var junk = new SortedDictionary<string, int>();
            const string shM = "Shadowmourne";
            const string vR = "Valanyr";
            const string drW = "Dragonwrath";
            var preciousMaterials = new Dictionary<string, int>();
            var sCount = 0;
            var vCount = 0;
            var dCount = 0;
            bool obtained = false;
            while (true)
            {
                var command = Console.ReadLine().Split(' ').ToArray();
                for (int i = 0; i < command.Length; i+=2)
                {
                    if (command[i+1].ToLower() == "shards" || command[i+1].ToLower()=="fragments" || command[i+1].ToLower()=="motes")
                    {
                        switch (command[i+1].ToLower())
                        {
                            case "shards":
                                sCount += int.Parse(command[i]);
                                break;
                            case "fragments":
                                vCount += int.Parse(command[i]);
                                break;
                            case "motes":
                                dCount += int.Parse(command[i]);
                                break;
                        }
                        if (vCount >= 250)
                        {
                            obtained = true;
                            Console.WriteLine(vR + " obtained!");
                            vCount -= 250;
                            preciousMaterials.Add("Fragments".ToLower(), vCount);
                            preciousMaterials.Add("Shards".ToLower(), sCount);
                            preciousMaterials.Add("Motes".ToLower(), dCount);

                        }
                        if (sCount >= 250)
                        {
                            obtained = true;
                            Console.WriteLine(shM + " obtained!");
                            sCount -= 250;
                            preciousMaterials.Add("Fragments".ToLower(), vCount);
                            preciousMaterials.Add("Shards".ToLower(), sCount);
                            preciousMaterials.Add("Motes".ToLower(), dCount);
                        }
                        if (dCount >= 250)
                        {
                            obtained = true;
                            Console.WriteLine(drW + " obtained!");
                            dCount -= 250;
                            preciousMaterials.Add("Fragments".ToLower(), vCount);
                            preciousMaterials.Add("Shards".ToLower(), sCount);
                            preciousMaterials.Add("Motes".ToLower(), dCount);
                        }

                    }
                    else
                    {
                        if (!junk.ContainsKey(command[i+1].ToLower()))
                        {
                            junk.Add(command[i+1].ToLower(), 0);
                        }
                        junk[command[i+1].ToLower()] += int.Parse(command[i]);
                    }
                    if (obtained) break;
                }
                //print precElse
                if (obtained) break;
            }
            var orderedD = preciousMaterials.OrderByDescending(k => k.Value).ThenBy(k => k.Key);
            foreach (var item in orderedD)
            {
                Console.WriteLine(item.Key + ":" + " " + item.Value);
            }
            //print junk
            foreach (var item in junk)
            {
                Console.WriteLine(item.Key + ":" + " " + item.Value);
            }
        }
    }
}
