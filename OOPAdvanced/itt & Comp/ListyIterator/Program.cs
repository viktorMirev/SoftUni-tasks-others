using OOPadv;
using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        IListyIterator myLysty;

        var data = Console.ReadLine().Split().ToList();
        data.RemoveAt(0);
        myLysty = new ListyIterator<string>(data);

        var line = Console.ReadLine();
        while (line != "END")
        {

            switch (line)
            {
                case "Move":
                    Console.WriteLine(myLysty.Move());
                    break;
                case "HasNext":
                    Console.WriteLine(myLysty.HasNext());
                    break;
                case "Print":
                    try
                    {
                        myLysty.Print();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }
                    break;
            }
            line = Console.ReadLine();
        }
    }


}
