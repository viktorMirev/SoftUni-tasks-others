namespace _03BarracksFactory.Core
{
    using System;
    using Contracts;
    using _03BarracksFactory.Core.Commands;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }
        
        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        // TODO: refactor for Problem 4
        private string InterpredCommand(string[] data, string commandName)
        {
            var cmdInterpreter = new CommandInterpreter(data, commandName, this.repository, this.unitFactory);
            string result = string.Empty;

            IExecutable myMethod = cmdInterpreter.InterpretCommand(data, commandName);
            result = myMethod.Execute().Trim();
            return result;
        }


      


       
    }
}
