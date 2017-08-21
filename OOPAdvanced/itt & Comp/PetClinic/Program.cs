using OOPadv;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<Pet> pets = new List<Pet>();
        List<Clinic> clinics = new List<Clinic>();

        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            try
            {
                var tokens = Console.ReadLine().Split();
                switch (tokens[0])
                {
                    case "Create":
                        if (tokens[1] == "Pet")
                        {
                            pets.Add(new Pet(tokens[2], int.Parse(tokens[3]), tokens[4]));
                        }
                        else if (tokens[1] == "Clinic")
                        {
                            clinics.Add(new Clinic(tokens[2], int.Parse(tokens[3])));
                        }
                        break;
                    case "Add":
                        Console.WriteLine(clinics.First(a => a.Name == tokens[2]).Add(pets.First(a => a.Name == tokens[1])));
                        break;
                    case "Release":
                        Console.WriteLine(clinics.First(a => a.Name == tokens[1]).Release());
                        break;
                    case "HasEmptyRooms":
                        Console.WriteLine(clinics.First(a => a.Name == tokens[1]).HasEmptyRooms());
                        break;
                    case "Print":
                        if (tokens.Length == 2)
                        {
                            clinics.First(a => a.Name == tokens[1]).Print();
                        }
                        else if (tokens.Length > 2)
                        {
                            clinics.First(a => a.Name == tokens[1]).Print(int.Parse(tokens[2]));
                        }
                        break;

                       
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message); ;
            }
           
        }
    }
}
