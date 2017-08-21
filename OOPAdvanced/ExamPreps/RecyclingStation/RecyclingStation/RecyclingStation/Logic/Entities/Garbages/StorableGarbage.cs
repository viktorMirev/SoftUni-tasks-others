using RecyclingStation.Logic.Attributes;
using RecyclingStation.Logic.Strategies;

namespace RecyclingStation.Logic.Entities.Garbages
{
    [Storable(typeof(StorableDisposalStrategy))]
    public class StorableGarbage : Garbage
    {
        public StorableGarbage(string name, double volumePerKg, double weight) : base(name, volumePerKg, weight)
        {
        }
    }
}
