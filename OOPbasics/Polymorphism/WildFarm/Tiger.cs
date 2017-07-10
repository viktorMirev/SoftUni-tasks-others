using System;

namespace WildFarm
{
    public class Tiger : Felime
    {
        public Tiger(string animalName, string animalType, double animalWeight, string livingR) : base(animalName, animalType, animalWeight, livingR)
        {
            this.FoodEaten = 0;
        }

        public override void eat(Food food)
        {
            if (food.GetType().Name != "Meat") throw new ArgumentException("Tigers are not eating that type of food!");

            this.FoodEaten = food.Quantity;
        }

        public override void makeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }
    }
}
