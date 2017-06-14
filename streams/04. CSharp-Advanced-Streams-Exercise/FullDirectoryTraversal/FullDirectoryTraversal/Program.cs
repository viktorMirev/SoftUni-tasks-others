using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullDirectoryTraversal
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Directory :)");
            var path = Console.ReadLine();
            var files = new Dictionary<string, List<FileInfo>>();
            TraverseIt(path, files);
        }

        private static void TraverseIt(string path, Dictionary<string, List<FileInfo>> files)
        {
            var di = new DirectoryInfo(path);
            var data = di.GetFiles("*.*", SearchOption.AllDirectories);
            foreach (var file in data)
            {
                if (files.ContainsKey(file.Extension))
                {
                    files[file.Extension].Add(file);
                }
                else
                {
                    files.Add(file.Extension, new List<FileInfo>() { file });
                }
            }
            string strPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            using (var writer = new StreamWriter(strPath + @"\result.txt"))
            {
                foreach (var extension in files.OrderByDescending(a => a.Value.Count).ThenBy(a => a.Key))
                {
                    writer.WriteLine(extension.Key);
                    foreach (var file in extension.Value.OrderByDescending(a => a.Length))
                    {
                        
                        writer.WriteLine("--" + file.Name + " - " + (double)file.Length / 1000 + "kb");
                    }
                }
            }
            
        }
    }
}
