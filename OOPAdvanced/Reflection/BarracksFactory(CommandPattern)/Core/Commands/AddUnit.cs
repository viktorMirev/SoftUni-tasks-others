using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    class AddUnitCommand : Command
    {
        public AddUnitCommand(string[] data, IRepository repo, IUnitFactory unitFactory) 
            : base(data, repo, unitFactory)
        {
          
        }

        public override string Execute()
        {
            string unitType = Data[1];
            IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);
            this.Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }

        
    }
}
