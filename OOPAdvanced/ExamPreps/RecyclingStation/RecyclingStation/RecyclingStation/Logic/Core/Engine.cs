using System;
using RecyclingStation.Logic.Contracts;
using System.Reflection;
using System.Linq;

namespace RecyclingStation.Logic.Core
{
    public class Engine : IEngine
    {
        private const string terminatingCommand = "TimeToRecycle";
        private IReader reader;
        private IWriter writer;
        private IRecyclingStation recyclingStation;

        private IReader Reader
        {
            get
            {
                return this.reader;
            }
            set
            {
                this.reader = value;
            }
        }

        private IWriter Writer
        {
            get
            {
                return this.writer;
            }
            set
            {
                this.writer = value;
            }
        }

        private IRecyclingStation RecyclingStation { get => recyclingStation; set => recyclingStation = value; }

        public Engine(IReader reader, IWriter writer, IRecyclingStation recyclingSt)
        {
            this.Reader = reader;
            this.Writer = writer;
            this.RecyclingStation = recyclingSt;
        }

        public void Run()
        {
            MethodInfo[] allMethods = this.recyclingStation.GetType().GetMethods();
            string line = this.reader.Read();
            while(line != terminatingCommand)
            {
                string[] data = line.Split(new string[] { " "}, StringSplitOptions.RemoveEmptyEntries);
                var commandName = data[0];
                string[] nonParsedParams = default(string[]);

                if (data.Length == 2) 
                {
                    nonParsedParams = data[1].Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                }

                MethodInfo currMethod = allMethods.Where(a => a.Name == commandName).First();

                ParameterInfo[] parameters = currMethod.GetParameters();

                object[] parsedParams = new object[parameters.Length];

                for (int i = 0; i < parameters.Length; i++)
                {
                   parsedParams[i] =  Convert.ChangeType(nonParsedParams[i], parameters[i].ParameterType);
                }

                object result = currMethod.Invoke(this.recyclingStation, parsedParams);

                this.writer.GatherLine(result.ToString());

                line = this.reader.Read();
            }


            writer.WriteAll();

          
        }
    }
}
