

using System;
using System.Collections.Generic;
using System.IO;

namespace SlicingFile
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string extention = ".avi";
           Slice(@"../../file.avi", @"../../", 3);
            Assemble(new List<string>(){@"..\..\part1.avi", @"..\..\part2.avi", @"..\..\part3.avi"},@"..\..\" );
        }

        public static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            
            using (var fileReader = new FileStream(sourceFile, FileMode.Open))
            {
                var lenght = fileReader.Length;
                long partSize = (long)(Math.Ceiling((decimal)(lenght)/parts));
                var buffer = new byte[partSize];
                for (int i = 1; i <= parts; i++)
                {
                    
                    using (var fileWriter = new FileStream(destinationDirectory + "part" + i + ".avi", FileMode.Create))
                    {

                        int number = fileReader.Read(buffer, 0, buffer.Length);
                        fileWriter.Write(buffer,0,number);
                    }
       
                }

            }
        }

        public static void Assemble(List<string> files, string destinationDirectory)
        {
            var buffer = new byte[4096];
            using (var assembeled = new FileStream(destinationDirectory + "assembled.avi", FileMode.Create))
            {
                for (int i = 0; i < files.Count; i++)
                {
                    using (var reader = new FileStream(files[i], FileMode.Open))
                    {
                        int number = reader.Read(buffer, 0, buffer.Length);
                        while (number != 0)
                        {
                            assembeled.Write(buffer,0,number);
                            number = reader.Read(buffer, 0, buffer.Length);
                        }
                    }
                }
            }           
        }
    }
}
