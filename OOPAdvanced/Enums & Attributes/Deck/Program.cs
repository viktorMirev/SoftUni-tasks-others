using System;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        Console.ReadLine();
        var suits = Enum.GetNames(typeof(CardSuit));
        var ranks = Enum.GetNames(typeof(CardRank));

        foreach (var suit in suits)
        {
            Console.WriteLine($"{ranks[ranks.Length - 1]} of {suit}");
            for (int i = 0; i < ranks.Length-1; i++)
            {
                Console.WriteLine($"{ranks[i]} of {suit}");
            }
        }
    }
}