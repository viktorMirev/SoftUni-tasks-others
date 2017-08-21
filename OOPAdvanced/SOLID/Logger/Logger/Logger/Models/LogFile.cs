using System;
using System.IO;
using System.Linq;
using System.Text;

namespace LoggerProgram.Models
{
    public class LogFile
    {
        private StringBuilder data;
        private int size;

        public LogFile()
        {
            this.data = new StringBuilder();
            this.size = 0;
        }

        public int Size
        {
            get => this.size;
        }

        public void Write(string line)
        {
            this.data.AppendLine(line);
            File.AppendAllText("log.txt",line + Environment.NewLine);
            foreach (char symbol in line.Where(a => char.IsLetter(a) == true))
            {
                 this.size += symbol;
            }
        }

        
    }
}
