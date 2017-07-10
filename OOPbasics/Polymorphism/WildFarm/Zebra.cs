using System;

namespace WildFarm
{
    public class Zebra : Mammal
    {
        public Zebra(string animalName, string animalType, double animalWeight, string livingR) : base(animalName, animalType, animalWeight, livingR)
        {
            this.FoodEaten = 0;
        }

        public override void eat(Food food)
        {
            if (food.GetType().Name != "Vegetable") throw new ArgumentException("Zebras are not eating that type of food!");
            this.FoodEaten = food.Quantity;
        }

        public override void makeSound()
        {
            Console.WriteLine("Zs");
        }
    }
}
