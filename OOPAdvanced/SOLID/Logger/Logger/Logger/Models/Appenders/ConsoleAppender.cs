using System;
using LoggerProgram.Interfaces;

namespace LoggerProgram.Models
{
    class ConsoleAppender : IAppender
    {
        private ILayout simpleLayout;

        public ConsoleAppender(ILayout simpleLayout)
        {
            this.simpleLayout = simpleLayout;
        }

        public ReportLevel ReportLevel { get; set; }

        public void Append(string time, string message, string status)
        {
            Console.WriteLine( this.simpleLayout.FormatData(time, message, status));
        }
    }
}
