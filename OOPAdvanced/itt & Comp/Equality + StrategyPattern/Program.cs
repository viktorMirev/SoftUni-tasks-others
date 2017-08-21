using OOPadv;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        
        var hSet = new HashSet<Person>();
        var sSet = new SortedSet<Person>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split();
            hSet.Add(new Person(tokens[0], int.Parse(tokens[1])));
            sSet.Add(new Person(tokens[0], int.Parse(tokens[1])));

        }

       

        Console.WriteLine(hSet.Count);
        Console.WriteLine(hSet.Count);
    }
}
