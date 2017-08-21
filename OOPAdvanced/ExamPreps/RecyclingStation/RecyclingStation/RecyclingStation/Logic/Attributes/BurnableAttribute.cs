using RecyclingStation.WasteDisposal.Attributes;
using System;

namespace RecyclingStation.Logic.Attributes
{
    public class BurnableAttribute : DisposableAttribute
    {
        public BurnableAttribute(Type strategyType) : base(strategyType)
        {
        }
    }
}
