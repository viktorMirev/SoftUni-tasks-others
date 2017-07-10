using System;

namespace OOPEx
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double distanceTravelled;

        public abstract void Refuel(double fuel);
        
        private double DistanceTravelled
        {
            get
            {
                return this.distanceTravelled;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.fuelQuantity:f2}";
        }

        public void Drive(double distance)
        {
            if (distance * this.FuelConsumption > this.FuelQuantity)
            {
                throw new Exception($"{this.GetType().Name} needs refueling");
            }

            this.AddDis(distance);
            this.FuelQuantity -= this.FuelConsumption * distance;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km"); 
        }


        protected void AddDis(double dis)
        {
            this.distanceTravelled += dis;
        }

        

        public Vehicle(double fuelQ, double fuelCons)
        {
            this.FuelQuantity = fuelQ;
            this.FuelConsumption = fuelCons;
        }

        public virtual double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            protected set
            {
                this.fuelQuantity = value;
            }
        }
        public virtual double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            protected set
            {
                this.fuelConsumption = value;
            }
        }

    }
}
