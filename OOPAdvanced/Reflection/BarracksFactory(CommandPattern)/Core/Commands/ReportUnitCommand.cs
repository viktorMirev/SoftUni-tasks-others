using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    class ReportUnitCommand : Command
    {
        public ReportUnitCommand(string[] data, IRepository repo, IUnitFactory unitFactory)
            : base(data, repo, unitFactory)
        {

        }

        public override string Execute()
        {
            string output = this.Repository.Statistics;
            return output;
        }


    }
}