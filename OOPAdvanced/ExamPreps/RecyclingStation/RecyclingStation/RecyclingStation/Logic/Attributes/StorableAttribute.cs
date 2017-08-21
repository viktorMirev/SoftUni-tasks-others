using RecyclingStation.WasteDisposal.Attributes;
using System;

namespace RecyclingStation.Logic.Attributes
{
   public  class StorableAttribute : DisposableAttribute
    {
        public StorableAttribute(Type strategyType) : base(strategyType)
        {
        }
    }
}
