using System;
using System.Collections.Generic;

namespace OOPEx
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var animals = new List<Animal>();

            while (line != "Beast!")
            {
                var type = line;
                var info = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);


                try
                {
                    switch (type)
                    {
                        case "Dog":
                            int age;
                            if (!int.TryParse(info[1], out age))
                            {
                                throw new ArgumentException("Invalid input!");
                            }
                            var d = new Dog(info[0], age, info[2]);
                            animals.Add(d);
                            break;
                        case "Frog":
                            int age1;
                            if (!int.TryParse(info[1], out age1))
                            {
                                throw new ArgumentException("Invalid input!");
                            }
                            var f = new Frog(info[0], age1, info[2]);
                            animals.Add(f);
                            break;
                        case "Cat":
                            int age2;
                            if(!int.TryParse(info[1], out age2))
                            {
                                throw new ArgumentException("Invalid input!");
                            }
                            var c = new Cat(info[0], age2, info[2]);
                            animals.Add(c);
                            break;
                        case "Kitten":
                            int age3;
                            if (!int.TryParse(info[1], out age3))
                            {
                                throw new ArgumentException("Invalid input!");
                            }
                            var k = new Kitten(info[0], age3);
                            animals.Add(k);
                            break;
                        case "Tomcat":
                            int age4;
                            if (!int.TryParse(info[1], out age4))
                            {
                                throw new ArgumentException("Invalid input!");
                            }
                            var t = new Tomcat(info[0],age4);
                            animals.Add(t);
                            break;
                        default: throw new ArgumentException("Invalid input!");

                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                line = Console.ReadLine();
               
            }
            foreach(var an in animals)
            {
                Console.WriteLine(an);
                an.ProduceSound();
            }
        }

    }
}
