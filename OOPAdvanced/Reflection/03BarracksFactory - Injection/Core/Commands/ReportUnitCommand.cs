using _03BarracksFactory.Contracts;
using _03BarracksFactory.Models.Attributes;

namespace _03BarracksFactory.Core.Commands
{
    class ReportUnitCommand : Command
    {
        [Injection]
        private IRepository repository;



        public ReportUnitCommand(string[] data)
            : base(data)
        {
            
        }

        public override string Execute()
        {
            string output = this.repository.Statistics;
            return output;
        }


    }
}