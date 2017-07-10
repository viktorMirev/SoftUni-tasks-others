
using OOPEx;
using System;

public class Program
    {
       public static void Main()
        {


        Car car = null;
        Truck truck = null;
        Bus bus = null;

        try
        {
            var cData = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
             car = new Car(double.Parse(cData[1]), double.Parse(cData[2]), double.Parse(cData[3]));

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {

            var tData = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
             truck = new Truck(double.Parse(tData[1]), double.Parse(tData[2]), double.Parse(tData[3]));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            var bData = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
             bus = new Bus(double.Parse(bData[1]), double.Parse(bData[2]), double.Parse(bData[3]));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
       


      


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
                        try
                        {
                            car.Refuel(double.Parse(data[2]));

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
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
                        try
                        {
                            truck.Refuel(double.Parse(data[2]));

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    break;

                case "bus":
                    if (data[0].ToLower() == "drive")
                    {
                        try
                        {        
                            bus.Drive(double.Parse(data[2]));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    else
                    {
                        if(data[0].ToLower() == "driveempty")
                        {
                            try
                            {
                                
                                bus.EmptyDrive(double.Parse(data[2]));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        else
                        {
                            try
                            {
                                bus.Refuel(double.Parse(data[2]));

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                       
                    }
                    break;
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }

}

