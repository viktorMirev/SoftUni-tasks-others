using OOPadv;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var li = new List<Box<int>>();

        for (int i = 0; i < n; i++)
        {
            var box = new Box<int>(int.Parse(Console.ReadLine()));
            li.Add(box);
        }

        
        var data = Console.ReadLine().Split().Select(int.Parse).ToArray();

        SwapElements(li, data[0], data[1]);

        foreach (var el in li)
        {
            Console.WriteLine(el);
        }
    }

    private static void SwapElements<T>(List<T> li, int v1, int v2)
    {
        var helper = li[v1];
        li[v1] = li[v2];
        li[v2] = helper;
    }
}
