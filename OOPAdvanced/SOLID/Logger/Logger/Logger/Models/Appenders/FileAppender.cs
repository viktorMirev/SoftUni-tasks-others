using System;
using LoggerProgram.Interfaces;
using LoggerProgram.Models;

namespace LoggerProgram.Models.Appenders
{
    class FileAppender : IAppender
    {
        private ILayout layout;
        public LogFile File { get; set; }
        public ReportLevel ReportLevel { get; set; }

        public FileAppender(ILayout layout)
        {
            this.layout = layout;
        }


        public void Append(string time, string message, string status)
        {
            this.File.Write(this.layout.FormatData(time, message, status));
        }

        
    }
}
