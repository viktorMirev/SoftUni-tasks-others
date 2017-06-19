using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var people = new Dictionary<string,int>();

        for (int i = 0; i < n; i++)
        {
            var data = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);

            people.Add(data[0],int.Parse(data[1]));

        }

       

        var condition = Console.ReadLine();

        int age = int.Parse(Console.ReadLine());

        var format = Console.ReadLine();

        var f = CreateFunc(condition, age);

        var printinfF = CreatePrint(format);

        Execute(f, printinfF, people);
    }

    private static void Execute(Func<int, bool> func, Action<KeyValuePair<string, int>> printinfF, Dictionary<string, int> people)
    {
        foreach (var person in people)
        {
            if (func(person.Value))
            {
                printinfF(person);
            }
        }
    }

    private static Action<KeyValuePair<string,int>> CreatePrint(string format)
    {
        if (format == "age")
        {
            return n => Console.WriteLine(n.Value);
        }

        if (format == "name age")
        {
            return n => Console.WriteLine(n.Key + " - " + n.Value);
        }

        return n => Console.WriteLine(n.Key);


    }

    private static Func<int,bool> CreateFunc(string condition, int age)
    {
        if (condition == "younger")
        {
            return n => n < age;
        }

        return n => n >= age;
    }
}

