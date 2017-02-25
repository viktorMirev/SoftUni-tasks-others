using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication5
{
    public class Event
    {
        public string Name { get; set; }
        public List<string> Participants { get; set; }
        public Event(string name, List<string> pp)
        {
            this.Name = name;
            this.Participants = pp;
        } 
        public void clean()
        {
            Participants = Participants.Distinct().ToList();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Regex validation = new Regex(@"\d+\s+#[^\s]+(\s+@[^\s]+)*");
            Dictionary<string, Event> Events = new Dictionary<string, Event>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Time for Code")
                {
                    break;
                }

              if (validation.Match(line).Success)
                {
                    var command = line.Split(new char[] {' ' , '\t'} , StringSplitOptions.RemoveEmptyEntries);
                    if (Events.ContainsKey(command[0]))
                    {
                        if (command[1].Substring(1) == Events[command[0]].Name)
                        {
                            var newPeople = command.Where(x => x[0] == '@' ).ToList();
                            Events[command[0]].Participants.AddRange(newPeople);
                            Events[command[0]].clean();
                        }
                        else continue;
                    }
                    else
                    {
                        Events.Add(command[0], new Event(command[1].Substring(1), command.Where(x => x[0] == '@').ToList()));
                        Events[command[0]].clean();
                       
                }
              }
            }
           
            foreach (var ev in Events.OrderByDescending(x => x.Value.Participants.Count).ThenBy(x => x.Value.Name))
            {
                Console.WriteLine(ev.Value.Name + " - " + ev.Value.Participants.Count);
                foreach (var pp in ev.Value.Participants.OrderBy(x => x))
                {
                    Console.WriteLine(pp);
                }
            }
        }

    }
}
