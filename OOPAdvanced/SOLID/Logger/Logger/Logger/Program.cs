﻿
using LoggerProgram;
using LoggerProgram.Models;
using LoggerProgram.Models.Appenders;

namespace LoggerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleLayout = new SimpleLayout();
            var consoleAppender = new ConsoleAppender(simpleLayout);
            consoleAppender.ReportLevel = ReportLevel.Error;
            var logger = new Logger(consoleAppender);
            logger.Info("3 / 31 / 2015 5:33:07 PM", " Everything seems fine");
            logger.Warn("3 / 31 / 2015 5:33:07 PM", " Warning: ping is too high - disconnect imminent");
            logger.Error("3 / 31 / 2015 5:33:07 PM", " Error parsing request");
            logger.Critical("3 / 31 / 2015 5:33:07 PM", " No connection string found in App.config");
            logger.Fatal("3 / 31 / 2015 5:33:07 PM", " mscorlib.dll does not respond");
        }
    }
}
