using System;

namespace OOPEx
{
    public class Car : Vehicle
    {
        public Car(double fuelQ, double fuelCons) : base(fuelQ, fuelCons)
        {
        }

 

        public override double FuelConsumption
        {
            get => base.FuelConsumption;
            protected set => base.FuelConsumption = value + 0.9;
        }
        

      
        public override void Refuel(double fuel)
        {
            this.FuelQuantity += fuel;
        }
    }
}
