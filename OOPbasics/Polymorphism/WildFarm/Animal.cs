namespace WildFarm
{
   public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten = 0;


        public int FoodEaten
        {
            get
            {
                return this.foodEaten;
            }
            protected set
            {
                this.foodEaten = value;
            }
        }

        public string AnimalName
        {
            get
            {
                return this.animalName;
            }
            protected set
            {
                this.animalName = value;
            }
        }


        public string AnimalType
        {
            get
            {
                return this.animalType;
            }
            protected set
            {
                this.animalType = value;
            }
        }


        public double AnimalWeight
        {
            get
            {
                return this.animalWeight;
            }
            protected set
            {
                this.animalWeight = value;
            }
        }

        public Animal(string animalName, string animalType, double animalWeight)
        {
            this.AnimalName = animalName;
            this.AnimalType = animalType;
            this.AnimalWeight = animalWeight;
        }




        public abstract void makeSound();
        public abstract void eat(Food food);
        
    }
}
