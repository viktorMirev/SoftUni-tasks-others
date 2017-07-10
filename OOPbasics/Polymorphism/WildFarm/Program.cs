using System;

namespace WildFarm
{
   public class Program
    {
        static void Main(string[] args)
        {

            var animal = Console.ReadLine();

            while (animal != "End")
            {
                var animalData = animal.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                Mammal current = null;  

                switch (animalData[0])
                {
                    case "Cat": current = new Cat(animalData[1], animalData[0], double.Parse(animalData[2]), animalData[3], animalData[4]);
                        break;
                    case "Tiger":
                        current = new Tiger(animalData[1], animalData[0], double.Parse(animalData[2]), animalData[3]);
                        break;
                    case "Zebra":
                        current = new Zebra(animalData[1], animalData[0], double.Parse(animalData[2]), animalData[3]);
                        break;
                    case "Mouse":
                        current = new Mouse(animalData[1], animalData[0], double.Parse(animalData[2]), animalData[3]);
                        break;
                }
                var foodData = Console.ReadLine().Split();
                Food currFood = null;
                if(foodData[0] == "Vegetable")
                {
                    currFood = new Vegetable(int.Parse(foodData[1]));
                }
                else
                {
                    currFood = new Meat(int.Parse(foodData[1]));
                }
               

                current.makeSound();
                try
                {
                    current.eat(currFood);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(current);

                animal = Console.ReadLine();
            }
        }
    }
}
