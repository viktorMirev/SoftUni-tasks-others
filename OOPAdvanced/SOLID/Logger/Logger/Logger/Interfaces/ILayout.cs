namespace LoggerProgram.Interfaces
{
    public interface ILayout
    {
        string FormatData(string time, string message, string status);
    }
}
