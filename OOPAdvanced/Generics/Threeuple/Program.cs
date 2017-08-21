using OOPadv;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var data = Console.ReadLine().Split();
        Threeple<string, string,string> first = new Threeple<string, string, string>(data[0] + " " + data[1], data[2],data[3]);

        data = Console.ReadLine().Split();
        bool helper = false;
        if (data[2] == "drunk") helper = true; 
        Threeple<string, int, bool> second = new Threeple<string, int, bool>(data[0], int.Parse(data[1]),helper);

        data = Console.ReadLine().Split();
        Threeple<string, double, string> third = new Threeple<string, double, string>(data[0], double.Parse(data[1]), data[2]);

        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine(third);

    }
}
