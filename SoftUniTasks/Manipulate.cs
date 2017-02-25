using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new List<string>();
            var collection = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }
                ,StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                var command = line
                .Split(new char[] { ' ', '\t' }
                ,StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                if (command[0] == "exchange")
                {
                    if (int.Parse(command[1])>=0 && int.Parse(command[1])<collection.Count)
                    {
                        var first = collection.GetRange(0, int.Parse(command[1]) + 1);
                        collection.RemoveRange(0, int.Parse(command[1]) + 1);
                        collection.AddRange(first);
                    }
                    else
                    {
                        result.Add("Invalid index");
                    }
                }


                if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        var index = 0;
                        var max = -1;
                        for (int i = 0; i < collection.Count; i++)
                        {
                            if (collection[i]%2 == 0 && collection[i]>=max)
                            {
                                index = i;
                                max = collection[i];
                            }
                        }
                        if (max >= 0 )
                        {
                           result.Add(index.ToString());
                        }
                        else
                        {
                            result.Add("No matches");
                        }
                    }
                    else
                    {
                        var index = 0;
                        var max = -1;
                        for (int i = 0; i < collection.Count; i++)
                        {
                            if (collection[i]%2 == 1 && collection[i]>=max)
                            {
                                index = i;
                                max = collection[i];
                            }
                        }
                        if (max >= 0)
                        {
                            result.Add(index.ToString());
                        }
                        else
                        {
                            result.Add("No matches");
                        }
                    }
                }



                if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        var index = 0;
                        var min = 100;
                        for (int i = 0; i < collection.Count; i++)
                        {
                            if (collection[i] % 2 == 0 && collection[i] <= min)
                            {
                                index = i;
                                min = collection[i];
                            }
                        }
                        if (min <100)
                        {
                            result.Add(index.ToString());
                        }
                        else
                        {
                            result.Add("No matches");
                        }
                    }
                    else
                    {
                        var index = 0;
                        var min = 100;
                        for (int i = 0; i < collection.Count; i++)
                        {
                            if (collection[i] % 2 == 1 && collection[i] <= min)
                            {
                                index = i;
                                min = collection[i];
                            }
                        }
                        if (min < 100)
                        {
                            result.Add(index.ToString());
                        }
                        else
                        {
                            result.Add("No matches");
                        }
                    }
                }



                if (command[0] == "first")
                {
                    if(int.Parse(command[1])<0 || int.Parse(command[1]) > collection.Count)
                    {
                       result.Add("Invalid count");
                    }
                    else
                    {
                        if (command[2] == "even")
                        {
                            var count = int.Parse(command[1]);
                            var evenList = new List<int>();
                            for (int i = 0; i < collection.Count; i++)
                            {
                                if (count == 0)
                                {
                                    break;
                                }
                                if (collection[i] % 2 == 0)
                                {
                                    count--;
                                    evenList.Add(collection[i]);
                                }
                            }
                            result.Add("[" + string.Join(", ", evenList) + "]");
                        }
                        else
                        {
                            var count = int.Parse(command[1]);
                            var oddList = new List<int>();
                            for (int i = 0; i < collection.Count; i++)
                            {
                                if (count == 0)
                                {
                                    break;
                                }
                                if (collection[i] % 2 == 1)
                                {
                                    count--;
                                    oddList.Add(collection[i]);
                                }
                            }
                           result.Add("[" + string.Join(", ", oddList) + "]");
                        }
                    }
                    
                }
                if (command[0] == "last")
                {
                    if (int.Parse(command[1]) < 0 || int.Parse(command[1]) > collection.Count)
                    {
                       result.Add("Invalid count");
                    }
                    else
                    {
                        if (command[2] == "even")
                        {
                            var count = int.Parse(command[1]);
                            var evenList = new List<int>();
                            for (int i = collection.Count - 1; i >= 0; i--)
                            {
                                if (count == 0)
                                {
                                    break;
                                }
                                if (collection[i] % 2 == 0)
                                {
                                    count--;
                                    evenList.Add(collection[i]);
                                }
                            }
                            evenList.Reverse();
                            result.Add("[" + string.Join(", ", evenList) + "]");
                        }
                        else
                        {
                            var count = int.Parse(command[1]);
                            var oddList = new List<int>();
                            for (int i = collection.Count - 1; i >= 0; i--)
                            {
                                if (count == 0)
                                {
                                    break;
                                }
                                if (collection[i] % 2 == 1)
                                {
                                    count--;
                                    oddList.Add(collection[i]);
                                }
                            }
                            oddList.Reverse();
                            result.Add("[" + string.Join(", ", oddList) + "]");
                        }
                    }
                   
                    
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("[" + string.Join(", ", collection) + "]");
        }
    }
}
