using System;
using LoggerProgram.Interfaces;

namespace LoggerProgram.Models
{
    public class Logger : ILogger
    {
        private IAppender[] appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        private void Log(string time, string message, ReportLevel status)
        {
            foreach (IAppender appender in this.appenders)
            {
                if((int)status >= (int)appender.ReportLevel)
                {
                    appender.Append(time, message, status.ToString());
                }
                
            }
           
        }

        public void Error(string time, string message)
        {
            this.Log(time, message, ReportLevel.Error);
        }

        public void Warn(string time, string message)
        {
            this.Log(time, message, ReportLevel.Warn);
        }

        public void Info(string time, string message)
        {
            this.Log(time, message,ReportLevel.Info);
        }

        public void Critical(string time, string message)
        {
            this.Log(time, message, ReportLevel.Critical);
        }

        public void Fatal(string time, string message)
        {
            this.Log(time, message, ReportLevel.Fatal);
        }
    }
}
