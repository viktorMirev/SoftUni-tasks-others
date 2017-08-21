namespace RecyclingStation.Logic.Contracts
{
    public interface IWriter
    {
        void WriteAll();

        void GatherLine(string line);


    }
}
