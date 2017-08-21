using System;
using LoggerProgram.Interfaces;

namespace LoggerProgram.Models
{
    public class SimpleLayout : ILayout
    {
        public string FormatData(string time, string message, string status)
        {
            return $"{time} - {status} - {message}";
        }
    }
}
