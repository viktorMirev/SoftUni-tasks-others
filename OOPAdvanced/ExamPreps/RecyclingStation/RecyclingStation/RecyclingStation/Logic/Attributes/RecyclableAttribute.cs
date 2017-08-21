using RecyclingStation.WasteDisposal.Attributes;
using System;

namespace RecyclingStation.Logic.Attributes
{
    public class RecyclableAttribute : DisposableAttribute
    {
        public RecyclableAttribute(Type strategyType) : base(strategyType)
        {
        }
    }
}
