using System;
using System.Collections.Generic;

namespace OOPEx
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var songs = new List<Song>();
            
           
                for (int i = 0; i < n; i++)
                {
                    var sData = Console.ReadLine().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                try
                {

                    if (sData.Length != 3) throw new ArgumentException("Invalid song.");
                    var aName = sData[0];
                    var sName = sData[1];
                    var timeData = sData[2].Split(':');
                    if (timeData.Length != 2) throw new ArgumentException("Invalid song length.");
                    int min;
                    int sec;
                    if (int.TryParse(timeData[0], out min) == false || int.TryParse(timeData[1], out sec) == false)
                    {
                        throw new ArgumentException("Invalid song length.");
                    }
                    var song = new Song(aName, sName, min, sec);

                    songs.Add(song);

                    Console.WriteLine("Song added.");
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

                var totalPlListTime = new TimeSpan();
                foreach (var s in songs)
                {
                var currSpan = s.total;
                totalPlListTime += currSpan;
                }
                Console.WriteLine($"Songs added: {songs.Count}");
                Console.WriteLine($"Playlist length: {totalPlListTime.Hours}h {totalPlListTime.Minutes}m {totalPlListTime.Seconds}s");
            
            

           
        }

    }
}
