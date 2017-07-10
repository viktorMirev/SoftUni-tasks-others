namespace OOPEx
{
   public class Bus : Vehicle
    {
        

        public Bus(double fuelQ, double fuelCons, double tCap) : base(fuelQ, fuelCons, tCap)
        {
           
        }

        public override double FuelConsumption
        {
            get => base.FuelConsumption + 1.4;
            protected set => base.FuelConsumption = value;
        }

        public void EmptyDrive(double km)
        {
            this.FuelConsumption  = this.FuelConsumption - 2.8;
            this.Drive(km);
            this.FuelConsumption += 1.4;
        }

       
    }
}
