namespace WildFarm
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string animalName, string animalType, double animalWeight, string livingR) : base(animalName, animalType, animalWeight)
        {
            this.LivingRegion = livingR;
        }

        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        public string LivingRegion
        {
            get
            {
                return this.livingRegion;
            }
            protected set
            {
                this.livingRegion = value;
            }
        }
    }
}
