namespace RecyclingStation.WasteDisposal.Attributes
{
    using System;

    /// <summary>
    /// An attribute class, that represents the base of all Disposable Attribute classes.
    /// </summary>
    
    [AttributeUsage(AttributeTargets.Class)]
    public class DisposableAttribute : Attribute
    {
        private Type strategyType;

        public DisposableAttribute(Type strategyType)
        {
            this.StrategyType = strategyType;
        }

        public Type StrategyType { get => strategyType; set => strategyType = value; }
    }
}
