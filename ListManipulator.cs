using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            
            while (command[0] != "print")
            {
                switch (command[0])
                {
                    case "add":
                        Add(numbers, command);
                        break;

                    case "addMany":
                        AddMany(numbers, command);
                        break;
                    case "contains":
                        Cointains(numbers, command);
                        break;
                    case "remove":
                        Remove(numbers, command);
                        break;
                    case "sumPairs":
                        SumPairs(ref numbers, command);
                        break;
                    case "shift":
                        Shift(ref numbers, command);
                        break;

                }
                command = Console.ReadLine().Split(' ').ToArray();
            }

            string answ = string.Join(", ", numbers);
            Console.WriteLine("[" + answ + "]");

        }

        private static List<int> Shift(ref List<int> numbers, string[] command)
        {
            var arr = new int[numbers.Count];
            
            for (int i = 0; i < numbers.Count; i++)
            {
                arr[i] = numbers[(i + int.Parse(command[1])) % numbers.Count];
            }
            return numbers = arr.ToList();

        }

        private static List<int> SumPairs(ref List<int> numbers, string[] command)
        {
            var result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Count - 1)
                {
                    result.Add(numbers[i]);
                } 
                else  result.Add(numbers[i]+ numbers[i + 1]);
                i++;
            }
            
            return (numbers = result);
        }

        private static void Remove(List<int> numbers, string[] command)
        {
            numbers.RemoveAt(int.Parse(command[1]));
        }

        private static void Cointains(List<int> numbers, string[] command)
        {
            if (numbers.Contains(int.Parse(command[1])))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == int.Parse(command[1]))
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            else Console.WriteLine(-1);
        }

        private static void AddMany(List<int> numbers, string[] command)
        {
            for (int i = command.Length-1; i >1; i--)
            {
                numbers.Insert(int.Parse(command[1]), int.Parse(command[i]));
            }
        }

        private static void Add(List<int> numbers, string[] command)
        {
               numbers.Insert(int.Parse(command[1]), int.Parse(command[2]));
        }
    }
}
