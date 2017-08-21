using OOPadv;
using System;

public class Engine
{
    private ICustomList<string> items;
    public Engine()
    {
        items = new CustomList<string>();
    }

    public void Run()
    {
        string line;
        while((line = Console.ReadLine()) != "END")
        {
            var data = line.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            switch (data[0])
            {
                case "Add":
                    items.Add(data[1]);
                    break;
                case "Contains":
                    Console.WriteLine(items.Contains(data[1]));
                    break;
                case "Remove":
                    items.Remove(int.Parse(data[1]));
                    break;
                case "Min":
                    Console.WriteLine(items.Min());
                    break;
                case "Max":
                    Console.WriteLine(items.Max());
                    break;
                case "Greater":
                    Console.WriteLine(items.CountGreaterThan(data[1]));
                    break;
                case "Swap":
                    items.Swap(int.Parse(data[1]), int.Parse(data[2]));
                    break;
                case "Print":
                    items.Print();
                    break;
                case "Sort":
                    items = Sorter<string>.Sort(items);
                        break;
                default: break;

            }
        }
    }
}