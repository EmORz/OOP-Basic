using OnlineRadioDatabase.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineRadioDatabase.Core
{
    public class Engine
    {
        private List<Song> songs;
        public Engine()
        {
            this.songs = new List<Song>();
        }
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    string[] input = Console.ReadLine().Split(';');
                    if (input.Length != 3)
                    {
                        throw new InvalidSongException();
                    }
                    string artistName = input[0];
                    string songName = input[1];
                    string[] tokens = input[2].Split(':');
                    int minutes ;
                    int seconds ;

                    if (!int.TryParse(tokens[0], out minutes))
                    {
                        throw new InvalidSongLengthException();
                    }

                    if (!int.TryParse(tokens[1], out seconds))
                    {
                        throw new InvalidSongLengthException();
                    }
                    Song song = new Song(artistName, songName, minutes, seconds);
                    songs.Add(song);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Print();
        }

        private void Print()
        {
            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }
            Console.WriteLine($"Songs added: {songs.Count}");
            var totalSeconds = songs.Sum(x => x.Minutes * 60 + x.Seconds);
            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            Console.WriteLine($"Playlist length: {time.Hours}h {time.Minutes}m {time.Seconds}s");
          
        }
    }
}
