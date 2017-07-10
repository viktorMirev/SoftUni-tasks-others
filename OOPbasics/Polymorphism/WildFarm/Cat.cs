using System;

namespace WildFarm
{
    public class Cat : Felime
    {
        private string breed;

        public string Breed
        {
            get
            {
                return this.breed;
            }
            private set
            {
                this.breed = value;
            }
        }

        public Cat(string animalName, string animalType, double animalWeight, string livingR, string breed) : base(animalName, animalType, animalWeight, livingR)
        {
            this.Breed = breed;
            this.FoodEaten = 0;
        }

        public override void eat(Food food)
        {
            this.FoodEaten = food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        public override void makeSound()
        {
            Console.WriteLine("Meowwww");
        }
    }
}
