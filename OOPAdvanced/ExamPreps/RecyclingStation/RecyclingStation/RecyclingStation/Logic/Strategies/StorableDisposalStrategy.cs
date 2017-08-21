using RecyclingStation.WasteDisposal.Interfaces;
using RecyclingStation.Logic.Data;

namespace RecyclingStation.Logic.Strategies
{
    public class StorableDisposalStrategy : GarbageDisposalStrategy
    {
        public override IProcessingData ProcessGarbage(IWaste garbage)
        {
            this.EnergyBalance = -0.13 * garbage.VolumePerKg * garbage.Weight;
            this.CapitalBalance = -0.65 * garbage.VolumePerKg * garbage.Weight;
            IProcessingData currData = new ProcessingData(this.EnergyBalance, this.CapitalBalance);
            return currData;
        }
    }
}
