using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    class RetireUnitCommand : Command
    {
        public RetireUnitCommand(string[] data, IRepository repo, IUnitFactory unitFactory)
            : base(data, repo, unitFactory)
        {

        }

        public override string Execute()
        {
            string unitType = Data[1];
            this.Repository.RemoveUnit(unitType);
            string output = unitType + " retired!";
            return output.Trim();
        }


    }
}
