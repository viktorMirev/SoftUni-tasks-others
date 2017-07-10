using System;

namespace OOPEx
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQ, double fuelCons) : base(fuelQ, fuelCons)
        {
        }

        public override double FuelConsumption
        {
            get => base.FuelConsumption;
            protected set => base.FuelConsumption = value + 1.6;
        }

        public override void Refuel(double fuel)
        {
            this.FuelQuantity += fuel * 0.95;
        }
    }
}
