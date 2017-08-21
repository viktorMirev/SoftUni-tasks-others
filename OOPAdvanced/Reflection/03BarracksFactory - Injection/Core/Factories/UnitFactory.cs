namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;
    using System.Reflection;

    public class UnitFactory : IUnitFactory
    {
        private const string prefix = "_03BarracksFactory.Models.Units.";
        public IUnit CreateUnit(string unitType)
        {
            Type currType = Type.GetType(prefix + unitType);
            ConstructorInfo ctor = currType.GetConstructor(new Type[]{});
            IUnit myInstance = (IUnit)ctor.Invoke(new object[]{});
            return myInstance;
        }
    }
}
