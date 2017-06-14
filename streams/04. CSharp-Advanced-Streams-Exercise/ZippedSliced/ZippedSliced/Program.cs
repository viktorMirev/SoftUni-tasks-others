using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZippedSliced
{
    class Program
    {
        public static void Main(string[] args)
        {
          
            Slice(@"../../file.avi", @"../../", 3);
            var files = Directory.GetFiles("../../").Where(a => a.EndsWith(".gz")).ToList();
            Assemble(files , @"..\..\");
        }

        public static void Slice(string sourceFile, string destinationDirectory, int parts)
        {

            using (var fileReader = new FileStream(sourceFile, FileMode.Open))
            {
                var lenght = fileReader.Length;
                long partSize = (long)(Math.Ceiling((decimal)(lenght) / parts));
                var buffer = new byte[partSize];
                for (int i = 1; i <= parts; i++)
                {

                    using (var fileWriter = new FileStream(destinationDirectory + "part" + i + ".gz", FileMode.Create))
                    {
                        using (var compressedStream = new GZipStream(fileWriter, CompressionMode.Compress))
                        {
                            int number = fileReader.Read(buffer, 0, buffer.Length);
                            compressedStream.Write(buffer, 0, number);
                        }

                       
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
                        using (var compress = new GZipStream(reader, CompressionMode.Decompress))
                        {
                            int number = compress.Read(buffer, 0, buffer.Length);
                            while (number != 0)
                            {
                                assembeled.Write(buffer, 0, number);
                                number = compress.Read(buffer, 0, buffer.Length);
                            }
                        }
                        
                    }
                }
            }
        }
    }
}
