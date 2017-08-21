using OOPadv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        var trLights = Console.ReadLine().Split();
        var all = new List<TrafficLight>();

        foreach (var li in trLights)
        {
            all.Add(new TrafficLight(li));
        }

        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            foreach (var tr in all)
            {
                tr.Update();
                Console.Write(tr.Light + " ");

            }
            Console.WriteLine();
        }
    }
}