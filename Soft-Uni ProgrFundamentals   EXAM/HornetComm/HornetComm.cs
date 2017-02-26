

namespace PracticalExamFundamentals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;




    class Program
    {
        static void Main()
        {
            Regex privateType = new Regex(@"([\d]+)\s<->\s([\d|A-Za-z]+)");
            Regex broadcastType = new Regex(@"([^\d]+)\s<->\s([A-Za-z|\d]+)");

            Dictionary<string, string> privateMessages = new Dictionary<string, string>();
            Dictionary<string, string> broadcastMessages = new Dictionary<string, string>();

            while (true)
            {

                var queryLine = Console.ReadLine();
                if (queryLine == "Hornet is Green")
                {
                    break;
                }

                var privateMatch = privateType.Match(queryLine); //proverka za PRIVATE
                var broadcastMatch = broadcastType.Match(queryLine); // proverka za BROADCAST

                if (broadcastMatch.Success && broadcastMatch.Value.Length == queryLine.Length)
                {
                    //Handle broadcast
                    var message = broadcastMatch.Groups[1].Value;
                    var orFriquency = broadcastMatch.Groups[2].Value;
                    StringBuilder friquency = new StringBuilder();
                    for (int i = 0; i < orFriquency.Length; i++)
                    {
                        if (orFriquency[i] >= 'a' && orFriquency[i] <= 'z')
                        {
                            friquency.Append((char)(orFriquency[i] - ('a' - 'A')));
                        }
                        else if (orFriquency[i] >= 'A' && orFriquency[i] <= 'Z')
                        {
                            friquency.Append((char)(orFriquency[i] + ('a' - 'A')));
                        }
                        else friquency.Append(orFriquency[i]);
                    }
                    broadcastMessages.Add(friquency.ToString(), message);
                }
                else if (privateMatch.Success && privateMatch.Value.Length == queryLine.Length)
                {
                    //Handle private
                    var message = privateMatch.Groups[2].Value;
                    var recCode = string.Join("", privateMatch.Groups[1].Value.Reverse());
                    privateMessages.Add(recCode, message);
                }
                else
                {
                    continue;
                }
               
            }
            Console.WriteLine("Broadcasts:");
            if (broadcastMessages.Count != 0 )
            {
                foreach (var brMSG in broadcastMessages)
                {
                    Console.WriteLine($"{brMSG.Key} -> {brMSG.Value}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (privateMessages.Count != 0 )
            {
                foreach (var prMSG in privateMessages)
                {
                    Console.WriteLine($"{prMSG.Key} -> {prMSG.Value}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
