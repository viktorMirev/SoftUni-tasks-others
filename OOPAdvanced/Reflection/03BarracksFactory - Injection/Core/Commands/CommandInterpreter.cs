using _03BarracksFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BarracksFactory.Core.Commands
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private string[] data;
        private string cmdName;
        private IRepository repository;
        private IUnitFactory unitFactory;


        public CommandInterpreter(string[] data, string commandName, IRepository repository, IUnitFactory unitFactory) 
        {
            this.data = data;
            this.cmdName = commandName;
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            switch (commandName)
            {
                case "add":
                    return new AddUnitCommand(data);
                case "report":
                    return new ReportUnitCommand(data);
                case "fight":
                    return new FightUnitCommand(data);
                case "retire":
                    return new RetireUnitCommand(data);
                default:
                    throw new InvalidOperationException("Invalid command!");
            }
        }
    }
}
