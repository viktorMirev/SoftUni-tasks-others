using RecyclingStation.Logic.Attributes;
using RecyclingStation.Logic.Strategies;

namespace RecyclingStation.Logic.Entities.Garbages
{
    [Recyclable(typeof(RecyclableDisposalStrategy))]
    public class RecyclableGarbage : Garbage
    {
        public RecyclableGarbage(string name, double volumePerKg, double weight) : base(name, volumePerKg, weight)
        {
        }
    }
}
