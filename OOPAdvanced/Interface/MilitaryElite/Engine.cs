using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPadv
{
    public class Engine
    { 
        public void Run()
        {
            
                var soldiers = new Dictionary<string, ISoldier>();
                var somePrivates = new Dictionary<string, Private>();

                var line = Console.ReadLine();
                while (line != "End")
                {
                    var data = line.Split();

                    switch (data[0])
                    {
                        case "Private":
                            var currPr = new Private(data[1], data[2], data[3], double.Parse(data[4]));
                            soldiers.Add(currPr.Id, currPr);
                            somePrivates.Add(currPr.Id, currPr);

                            break;
                        case "Spy":
                            var currSpy = new Spy(data[1], data[2], data[3], int.Parse(data[4]));
                            soldiers.Add(currSpy.Id, currSpy);
                            break;
                        case "LeutenantGeneral":
                            var privates = new List<Private>();
                            for (int i = 5; i < data.Length; i++)
                            {
                                privates.Add(somePrivates[data[i]]);
                            }
                            var currLeu = new LeutenantGeneral(data[1], data[2], data[3], double.Parse(data[4]), privates);
                            soldiers.Add(currLeu.Id, currLeu);
                            break;
                        case "Engineer":
                            var repairs = new List<Repair>();
                            for (int i = 6; i < data.Length; i += 2)
                            {
                                var rep = new Repair(data[i], int.Parse(data[i + 1]));
                                repairs.Add(rep);
                            }
                            try
                            {
                                var currEng = new Engineer(data[1], data[2], data[3], double.Parse(data[4]), data[5], repairs);
                                soldiers.Add(currEng.Id, currEng);
                            }
                            catch (Exception e) { }



                            break;
                        case "Commando":
                            var missions = new List<Mission>();
                            for (int i = 6; i < data.Length; i += 2)
                            {
                                try
                                {
                                    var mission = new Mission(data[i], data[i + 1]);
                                    missions.Add(mission);
                                }
                                catch (Exception e) { }
                            }
                            try
                            {
                                var currEng = new Commando(data[1], data[2], data[3], double.Parse(data[4]), data[5], missions);
                                soldiers.Add(currEng.Id, currEng);
                            }
                            catch (Exception e) { }


                            break;
                    }


                    line = Console.ReadLine();
                }

                foreach (var sold in soldiers)
                {
                    Console.WriteLine(sold.Value);
                }
        }
    }
    
}
