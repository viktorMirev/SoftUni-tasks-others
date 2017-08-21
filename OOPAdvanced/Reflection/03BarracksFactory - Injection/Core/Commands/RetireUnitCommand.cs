using _03BarracksFactory.Contracts;
using _03BarracksFactory.Models.Attributes;

namespace _03BarracksFactory.Core.Commands
{
    class RetireUnitCommand : Command
    {
        [Injection]
        private IRepository repository;

        public RetireUnitCommand(string[] data)
            : base(data)
        {
            
        }

        public override string Execute()
        {
            string unitType = Data[1];
            this.repository.RemoveUnit(unitType);
            string output = unitType + " retired!";
            return output.Trim();
        }


    }
}
