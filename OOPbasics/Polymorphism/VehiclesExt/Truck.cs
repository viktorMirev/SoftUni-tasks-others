using System;

namespace OOPEx
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQ, double fuelCons, double tCap) : base(fuelQ, fuelCons,tCap)
        {
        }

        public override double FuelConsumption
        {
            get => base.FuelConsumption;
            protected set => base.FuelConsumption = value + 1.6;
        }

        public override void Refuel(double fuel)
        {
            if (fuel <= 0) throw new ArgumentException("Fuel must be a positive number");
            // if (this.FuelQuantity + fuel*0.95 > this.TankCapacity) throw new ArgumentException("Cannot fit fuel in tank");
            this.FuelQuantity += fuel * 0.95;
        }
    }
}
