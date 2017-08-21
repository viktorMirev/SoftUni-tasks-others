using OOPadv;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var li = new List<Box<double>>();

        for (int i = 0; i < n; i++)
        {
            var box = new Box<double>(double.Parse(Console.ReadLine()));
            li.Add(box);
        }

        
        var data = new Box<double>(double.Parse(Console.ReadLine()));

        Console.WriteLine(CountGreaterThan(li,data));
    }

    private static int CountGreaterThan<T>(List<T> li, T data)
        where T : IComparable<T>
    {
        return li.Count(a => a.CompareTo(data) > 0);    
    }

    private static void SwapElements<T>(List<T> li, int v1, int v2)
    {
        var helper = li[v1];
        li[v1] = li[v2];
        li[v2] = helper;
    }
}
