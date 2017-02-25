using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication8
{
    
    class Program
    {
        static void Main()
        {
            Regex validation = new Regex(@"(\d+)([a-zA-Z]+)([^a-zA-Z\s]+)?");
            Dictionary<string,string> decripted = new Dictionary<string, string>();
            while (true)
            {
                //validation
                var line = Console.ReadLine();
                if (line == "Over!")
                {
                    break;
                }
                var match = validation.Match(line);
                if (!match.Success || match.Value.Length != line.Length)
                {
                    continue;
                }
                var m = int.Parse(Console.ReadLine());
                if (m != match.Groups[2].Value.Length)
                {
                    continue;
                }

                //decrypting
                Regex nums = new Regex(@"\d");
                var fPattern = match.Groups[1].Value;
                var sPattern = match.Groups[3].Value;
                var dMatches = nums.Matches(sPattern);
                sPattern = string.Empty;
                foreach (Match item in dMatches)
                {
                    sPattern += item.Value;
                }
                var text = match.Groups[2].Value;
                StringBuilder decryptedText = new StringBuilder();
                foreach (var index in fPattern)
                {
                    var i = index - '0';
                    if (i<0 || i>=text.Length)
                    {
                        decryptedText.Append(" ");
                    }
                    else
                    {
                        decryptedText.Append(text[i]);
                    }
                }
                if (sPattern.Length !=0)
                {
                    foreach (var index in sPattern)
                    {
                        var i = index - '0';
                        if (i < 0 || i >= text.Length)
                        {
                            decryptedText.Append(" ");
                        }
                        else
                        {
                            decryptedText.Append(text[i]);
                        }
                    }
                }
                
                decripted.Add(text, decryptedText.ToString());

            }
            foreach (var item in decripted)
            {
                Console.WriteLine($"{item.Key} == {item.Value}");
            }
        }
    }
}
