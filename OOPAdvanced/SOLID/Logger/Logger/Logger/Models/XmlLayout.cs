using LoggerProgram.Interfaces;
using System.Text;

namespace LoggerProgram.Models
{
    public class XmlLayout : ILayout
    {
        public string FormatData(string time, string message, string status)
        {
            var formatted = new StringBuilder();
            formatted.AppendLine("<log>");
            formatted.AppendLine($"   <date>{time}</date>");
            formatted.AppendLine($"   <level>{status}</level>");
            formatted.AppendLine($"   <message>{message}</message>");
            formatted.AppendLine("</log>");

            return formatted.ToString();

        }
    }
}
