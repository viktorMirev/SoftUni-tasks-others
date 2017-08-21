using OOPadv;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var people = new List<Person>();

        var line = Console.ReadLine();

        while (line != "END")
        {
            var tokens = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            people.Add(new Person(tokens[0], int.Parse(tokens[1]), tokens[2]));
            line = Console.ReadLine();
        }
        var index = int.Parse(Console.ReadLine()) - 1;

        var myPerson = people[index];

        var likeMe = 0;

        foreach (var p in people)
        {
            if(myPerson.CompareTo(p) == 0)
            {
                likeMe++;
            }
        }

        if (likeMe > 1)
        {
            Console.WriteLine($"{likeMe} {people.Count - likeMe} {people.Count}");
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
}
