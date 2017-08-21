using OOPadv;
using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        IStack<int> myStack = new Stack<int>();

        var line = Console.ReadLine();
        while (line != "END")
        {
           

            if (line.StartsWith("Pop"))
            {
                try
                {
                    myStack.Pop();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                line = line.Remove(0, 5);
                var nums = line.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                myStack.Push(nums.Select(int.Parse));
            }
           
            line = Console.ReadLine();
        }

        foreach (var item in myStack)
        {
            Console.WriteLine(item);
        }
        foreach (var item in myStack)
        {
            Console.WriteLine(item);
        }
    }


}
