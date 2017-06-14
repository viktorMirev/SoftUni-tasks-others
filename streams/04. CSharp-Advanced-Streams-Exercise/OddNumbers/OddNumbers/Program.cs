
using System;
using System.IO;

namespace OddNumbers
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            using (var stream = new StreamReader(@"../../test.txt"))
            {
                var line = stream.ReadLine();
                var count = 1;
                while (line!=null)
                {
                    Console.WriteLine(stream.ReadLine());
                    line = stream.ReadLine();
                }
            }
        }
    }
}
