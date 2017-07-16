using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var manager = new DraftManager();


        var args = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);

        while (args[0] != "Shutdown")
        {
           
                var news = args.ToList();
                news.RemoveAt(0);
                switch (args[0])
                {
                    case "RegisterHarvester":
                    Console.WriteLine(manager.RegisterHarvester(news.ToList()));
                    break;

                    case "RegisterProvider":
                    Console.WriteLine(manager.RegisterProvider(news.ToList()));
                    break;

                    case "Day":
                    Console.WriteLine(manager.Day());
                    break;
                       
                       
                    case "Mode":
                    Console.WriteLine(manager.Mode(news.ToList()));
                    break;

                    case "Check":
                    Console.WriteLine(manager.Check(news.ToList()));
                    break;

                    default: break;
                    
                    
                }       
            args = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
        }

        Console.WriteLine(manager.ShutDown());
    }   
}

