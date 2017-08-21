using RecyclingStation.WasteDisposal.Interfaces;
using RecyclingStation.Logic.Data;

namespace RecyclingStation.Logic.Strategies
{
    public class RecyclableDisposalStrategy : GarbageDisposalStrategy
    {
        public override IProcessingData ProcessGarbage(IWaste garbage)
        {
            this.EnergyBalance = -garbage.VolumePerKg * garbage.Weight * 0.5;
            this.CapitalBalance = 400 * garbage.Weight;
            IProcessingData currData = new ProcessingData(this.EnergyBalance, this.CapitalBalance);
            return currData;
        }
    }
}
