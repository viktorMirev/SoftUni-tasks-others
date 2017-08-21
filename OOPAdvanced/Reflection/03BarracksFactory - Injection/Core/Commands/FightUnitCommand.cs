using System;
using _03BarracksFactory.Contracts;
using _03BarracksFactory.Models.Attributes;

namespace _03BarracksFactory.Core.Commands
{
    internal class FightUnitCommand : Command
    {
        public FightUnitCommand(string[] data) : base(data)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return null;
        }

        
    }

        
       
        
    
}