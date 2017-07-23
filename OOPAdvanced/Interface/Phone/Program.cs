
using OOPadv;
using System;

public class Program
{
    public static void Main()
    {
        var phone = new Phone();
        var nums = Console.ReadLine().Split();
        foreach (var num in nums)
        {
            Console.WriteLine( phone.Call(num));
        }
        var urls = Console.ReadLine().Split();
        foreach (var ur in urls)
        {
            Console.WriteLine(phone.Browse(ur));
        }
    }
}
