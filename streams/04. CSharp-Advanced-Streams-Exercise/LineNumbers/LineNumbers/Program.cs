﻿
using System.IO;

namespace LineNumbers
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"../../original.txt"))
            {
                using (var writer = new StreamWriter(@"../../lined.txt"))
                {
                    var line = reader.ReadLine();
                    var count = 0;
                    while (line!=null)
                    {
                        writer.WriteLine("line " + count + ":  " + line);
                        count++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
