using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var words = new Dictionary<string,int>();
            using (var wordsReader = new StreamReader(@"../../words.txt"))
            {
                using (var textReader = new StreamReader(@"../../text.txt"))
                {
                    var line = wordsReader.ReadLine();
                    while (line!=null)
                    {
                        words.Add(line.ToLower(),0);
                        line = wordsReader.ReadLine();
                    }


                    var textLine = textReader.ReadLine();
                   
                    while (textLine!=null)
                    {
                        var textLineWords = textLine
                            .Split(new char[] { ' ', ',', '.', '"', ':', ';', '!', '?', '-', ')', '(', '{', '}' }
                                , StringSplitOptions.RemoveEmptyEntries);

                        foreach (var word in textLineWords)
                        {
                            if (words.ContainsKey(word.ToLower()))
                            {
                                words[word.ToLower()]++;
                            }
                        }
                        textLine = textReader.ReadLine();
                    }

                }
            }

            using (var writer = new StreamWriter(@"../../result.txt"))
            {
                foreach (var pair in words.OrderByDescending(a => a.Value))
                {
                    writer.WriteLine(pair.Key + " - " + pair.Value);
                }
            }
        }
    }
}
