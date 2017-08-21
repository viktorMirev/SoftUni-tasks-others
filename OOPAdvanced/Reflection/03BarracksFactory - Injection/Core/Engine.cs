namespace _03BarracksFactory.Core
{
    using System;
    using Contracts;
    using _03BarracksFactory.Core.Commands;
    using _03BarracksFactory.Models.Attributes;
    using System.Reflection;
    using System.Linq;

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
            myMethod = InjectionMethod(myMethod, typeof(InjectionAttribute));
            result = myMethod.Execute().Trim();
            return result;
        }

        private IExecutable InjectionMethod(IExecutable myMethod, Type attrType)
        {
            FieldInfo[] commandFields = myMethod.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            FieldInfo[] engineFields = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo field in commandFields)
            {
                var attributeIndicatingInjection = field.GetCustomAttribute(attrType);
                if(attributeIndicatingInjection != null)
                {
                    if(engineFields.Any(a => a.FieldType == field.FieldType))
                    {
                        field.SetValue(myMethod, engineFields.Where(a => a.FieldType == field.FieldType).First().GetValue(this));
                    }
                }
            }
            return myMethod;
        }
    }
}
