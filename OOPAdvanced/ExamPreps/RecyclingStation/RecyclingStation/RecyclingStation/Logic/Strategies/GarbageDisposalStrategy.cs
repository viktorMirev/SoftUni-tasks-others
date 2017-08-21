using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.Logic.Strategies
{
    public abstract class GarbageDisposalStrategy : IGarbageDisposalStrategy
    {
        private double energyBalance;
        private double capitalBalance;

        public GarbageDisposalStrategy()
        {
            this.EnergyBalance = 0;
            this.CapitalBalance = 0;
        }

        public double CapitalBalance { get => capitalBalance; protected set => capitalBalance = value; }
        public double EnergyBalance { get => energyBalance; protected set => energyBalance = value; }

        public abstract IProcessingData ProcessGarbage(IWaste garbage);
        
    }
}
