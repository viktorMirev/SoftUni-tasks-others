using System;

namespace OOPEx
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        private double fuelConsumption;

        private double distanceTravelled;

        private double tankCapacity;



        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            protected set
            {
                this.tankCapacity = value;
            }
        }

        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0) throw new ArgumentException("Fuel must be a positive number");
            if (this.fuelQuantity + fuel > this.tankCapacity) throw new ArgumentException("Cannot fit fuel in tank");

            this.fuelQuantity += fuel;
        }
        
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

        public Vehicle(double fuelQ, double fuelCons, double tCap)
        {
            this.FuelQuantity = fuelQ;
            this.FuelConsumption = fuelCons;
            this.TankCapacity = tCap;
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
