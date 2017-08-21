using OOPadv;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var data = Console.ReadLine().Split();
        OOPadv.Tuple<string, string> first = new OOPadv.Tuple<string, string>(data[0] + " " + data[1], data[2]);

        data = Console.ReadLine().Split();
        OOPadv.Tuple<string, int> second = new OOPadv.Tuple<string, int>(data[0] , int.Parse(data[1]));

        data = Console.ReadLine().Split();
        OOPadv.Tuple<int, double> third = new OOPadv.Tuple<int,double>(int.Parse(data[0]), double.Parse(data[1]));

        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine(third);

    }
}
