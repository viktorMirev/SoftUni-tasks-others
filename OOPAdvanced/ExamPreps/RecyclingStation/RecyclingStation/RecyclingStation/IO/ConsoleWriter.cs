using RecyclingStation.Logic.Contracts;
using System;
using System.Text;

namespace RecyclingStation.IO
{
    public class ConsoleWriter : IWriter
    {
        private StringBuilder allLines;

        public ConsoleWriter()
            : this(new StringBuilder())
        {

        }

        public ConsoleWriter(StringBuilder firstInput)
        {
            this.AllLines = firstInput;
        }

        public StringBuilder AllLines
        {
            get
            {
                return this.allLines;
            }
            private set
            {
                this.allLines = value;
            }
        }

        public void GatherLine(string line)
        {
            this.allLines.AppendLine(line);
        }

        public void WriteAll()
        {
            Console.WriteLine(allLines.ToString().Trim());
        }
    }
}
