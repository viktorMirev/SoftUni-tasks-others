using OOPadv;
using System;

public class Program
{
    public static void Main()
    {

        Console.WriteLine(Console.ReadLine() + ":");

        foreach (var item in Enum.GetValues(typeof(CardRank)))
        {
            Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");
        }
    }
}