using RecyclingStation.Logic.Contracts;
using System;

namespace RecyclingStation.IO
{
    public class ConsoleReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
