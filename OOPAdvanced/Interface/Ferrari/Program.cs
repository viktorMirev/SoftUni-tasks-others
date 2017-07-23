using OOPadv;
using System;

public class Program
{
    public static void Main()
    {
        var car = new Ferrari(Console.ReadLine());
        Console.WriteLine(car);

        string ferrariName = typeof(Ferrari).Name;

        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;

        if (!isCreated)

        {

            throw new Exception("No interface ICar was created");

}
    }
}
