﻿using OOPadv;
using System;

public class Program
{
    public static void Main()
    {
        var names = Enum.GetNames(typeof(CardSuits));

        Console.WriteLine(Console.ReadLine() + ":");

        foreach (var item in Enum.GetValues(typeof(CardSuits)))
        {
            Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");
        }
    }
}