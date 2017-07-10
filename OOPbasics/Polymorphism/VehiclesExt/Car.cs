using System;

namespace OOPEx
{
    public class Car : Vehicle
    {
        public Car(double fuelQ, double fuelCons, double tCap) : base(fuelQ, fuelCons,tCap)
        {
        }

        public override double FuelConsumption
        {
            get => base.FuelConsumption;
            protected set => base.FuelConsumption = value + 0.9;
        }
             
        
    }
}
