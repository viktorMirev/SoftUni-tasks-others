using RecyclingStation.Logic.Attributes;
using RecyclingStation.Logic.Strategies;

namespace RecyclingStation.Logic.Entities.Garbages
{
    [Burnable(typeof(BurnableDisposalStrategy))]
    public class BurnableGarbage : Garbage
    {
        public BurnableGarbage(string name, double volumePerKg, double weight) : base(name, volumePerKg, weight)
        {
        }
    }
}
