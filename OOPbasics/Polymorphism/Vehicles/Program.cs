
using OOPEx;
using System;

public class Program
    {
       public static void Main()
        {
        var cData = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        var car = new Car(double.Parse(cData[1]), double.Parse(cData[2]));
        var tData = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        var truck = new Truck(double.Parse(tData[1]), double.Parse(tData[2]));


        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var data = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            switch (data[1].ToLower())
            {
                case "car":
                    if (data[0].ToLower() == "drive")
                    {
                        try
                        {
                            car.Drive(double.Parse(data[2]));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    else
                    {
                        car.Refuel(double.Parse(data[2]));
                    }
                    break;
                case "truck":
                    if (data[0].ToLower() == "drive")
                    {
                        try
                        {
                            truck.Drive(double.Parse(data[2]));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    else
                    {
                        truck.Refuel(double.Parse(data[2]));
                    }
                    break;
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
    }

}

