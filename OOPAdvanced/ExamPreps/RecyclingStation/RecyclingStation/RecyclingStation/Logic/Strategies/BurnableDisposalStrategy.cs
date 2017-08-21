using RecyclingStation.WasteDisposal.Interfaces;
using RecyclingStation.Logic.Data;

namespace RecyclingStation.Logic.Strategies
{
    public class BurnableDisposalStrategy : GarbageDisposalStrategy
    {
        public override IProcessingData ProcessGarbage(IWaste garbage)
        {
            this.EnergyBalance = 0.8 * garbage.VolumePerKg * garbage.Weight;
            this.CapitalBalance = 0;
            IProcessingData currData = new ProcessingData(this.EnergyBalance, this.CapitalBalance);
            return currData;
        }
    }
}
