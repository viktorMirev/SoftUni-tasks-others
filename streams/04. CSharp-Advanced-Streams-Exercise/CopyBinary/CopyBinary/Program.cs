using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyBinary
{
   public static class Program
    {
        public static void Main(string[] args)
        {
            var buffer = new byte[4096];
            using (var reader = new FileStream(@"../../original.png", FileMode.Open))
            {
                using (var writer = new FileStream(@"../../notOriginal.png",FileMode.Create))
                {
                    int number = reader.Read(buffer, 0, buffer.Length);
                    while (number!=0)
                    {
                        writer.Write(buffer,0,number);
                        number = reader.Read(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
