using System;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        var cat = Console.ReadLine();
        Type type;
        if (cat == "Rank")
        {
            type = typeof(CardRank);

        }
        else
        {
            type = typeof(CardSuit);
        }

        var attrs = type.GetCustomAttributes(false);

        Console.WriteLine(attrs[0]);
        

       
    }
}