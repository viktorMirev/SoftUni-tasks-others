using LoggerProgram;

namespace LoggerProgram.Interfaces
{
    public interface IAppender
    {
        void Append(string time, string message, string status);

        ReportLevel ReportLevel { get; set; }

    }
}
