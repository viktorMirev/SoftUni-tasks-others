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
                    try
                    {
                        Console.WriteLine(manager.RegisterHarvester(news.ToList()));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                   
                    break;
                    case "RegisterProvider":
                    try
                    {
                        Console.WriteLine(manager.RegisterProvider(news.ToList()));
                    }            
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;

                    case "Day":
                    try
                    {
                        Console.WriteLine(manager.Day());
                    }
                     catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                       
                        break;
                    case "Mode":

                    try
                    {
                        Console.WriteLine(manager.Mode(news.ToList()));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                   
                       
                        break;
                    case "Check":

                    try
                    {
                        Console.WriteLine(manager.Check(news.ToList()));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }


                    
                        break;
                    default: break;
                    
                    
                }
            
            
         

            args = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
        }

        Console.WriteLine(manager.ShutDown());
    }   
}

