namespace RecyclingStation.WasteDisposal
{
    using System;
    using System.Linq;
    using RecyclingStation.WasteDisposal.Attributes;
    using RecyclingStation.WasteDisposal.Interfaces;

    public class GarbageProcessor : IGarbageProcessor
    {
        private IStrategyHolder strategyHolder;

        public GarbageProcessor(IStrategyHolder strategyHolder)
        {
            this.StrategyHolder = strategyHolder;
        }

        public GarbageProcessor() : this(new StrategyHolder())
        {
        }

        public IStrategyHolder StrategyHolder
        {
            get
            {
                return this.strategyHolder;
            }
            private set
            {
                this.strategyHolder = value;
            }
        }

        public IProcessingData ProcessWaste(IWaste garbage)
        {
            Type type = garbage.GetType();
            DisposableAttribute disposalAttribute = (DisposableAttribute)type.GetCustomAttributes(typeof(DisposableAttribute), true).First();
            IGarbageDisposalStrategy currentStrategy;

            if (disposalAttribute == null)
            {
                throw new ArgumentException(
                    "The passed in garbage does not implement a supported Disposable Strategy Attribute.");
            }

            if (!this.strategyHolder.GetDisposalStrategies.ContainsKey(disposalAttribute.GetType()))
            {
                Type attributeType = disposalAttribute.GetType();
                IGarbageDisposalStrategy addedStrategy = (IGarbageDisposalStrategy)Activator.CreateInstance(disposalAttribute.StrategyType);
                this.strategyHolder.AddStrategy(attributeType,addedStrategy);
            }

            currentStrategy = this.strategyHolder.GetDisposalStrategies[disposalAttribute.GetType()];
            

            return currentStrategy.ProcessGarbage(garbage);
        }
    }
}
