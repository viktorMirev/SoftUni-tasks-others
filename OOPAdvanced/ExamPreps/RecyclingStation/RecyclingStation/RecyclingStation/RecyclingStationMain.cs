using RecyclingStation.IO;
using RecyclingStation.Logic.Contracts;
using RecyclingStation.Logic.Core;
using RecyclingStation.Logic.Factories;
using RecyclingStation.WasteDisposal;
using RecyclingStation.WasteDisposal.Interfaces;

public class RecyclingStationMain
{
    public static void Main()
    {
        IReader reader = new ConsoleReader();
        IWriter writer = new ConsoleWriter();
        IStrategyHolder strategyHolder = new StrategyHolder();

        IRecyclingStation recyclingManager = new RecyclingManager(new GarbageProcessor(strategyHolder), new GarbageFactory());

        IEngine engine = new Engine(reader, writer, recyclingManager);

        engine.Run();
    }
}
