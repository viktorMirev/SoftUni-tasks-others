﻿using _03BarracksFactory.Contracts;
using _03BarracksFactory.Models.Attributes;

namespace _03BarracksFactory.Core.Commands
{
    class AddUnitCommand : Command
    {
        [Injection]
        private IUnitFactory unitFactory;
        [Injection]
        private IRepository repository;


        public AddUnitCommand(string[] data) 
            : base(data)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];
            IUnit unitToAdd = this.unitFactory.CreateUnit(unitType);
            this.repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }

        
    }
}
