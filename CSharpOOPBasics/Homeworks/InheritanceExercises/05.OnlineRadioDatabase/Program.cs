using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.OnlineRadioDatabase.Exceptions;

namespace _05.OnlineRadioDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PlayList playList = new PlayList();

            for (int i = 0; i < n; i++)
            {
                try
                {
                    List<string> inputParameters =
                        Console.ReadLine().Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries).ToList();

                    string artistName = inputParameters[0];
                    string songName = inputParameters[1];
                    string length = inputParameters[2];

                    List<int> lengthSplit = length.Split(':').Select(int.Parse).ToList();

                    Song song = new Song(artistName, songName, lengthSplit[0], lengthSplit[1]);

                    playList.SongCollection.Add(song);

                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            List<long> playListLength = playList.CalculatePlayListLength();

            Console.WriteLine("Songs added: {0}", playList.SongCollection.Count);
            Console.WriteLine("Playlist length: {0}h {1}m {2}s", playListLength[2], playListLength[1], playListLength[0]);

        }
    }
}
