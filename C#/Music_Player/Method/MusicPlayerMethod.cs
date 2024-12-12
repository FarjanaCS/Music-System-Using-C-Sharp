using Music_Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Method
{
    //Concrete Method Implementation
    public class MusicPlayerMethod : IMusicPlayerMethod
    {
        private readonly List<string> play = new List<string>();
        public void Play(Song song, Artist artist)
        {
           Console.WriteLine($"Playing: {song.Title} by {artist.Name} of {song.Genre} ");
   
        }

        public void Stop()
        {
            Console.WriteLine("Stopping Playback");
            //Logic to Stop Playback
        }
    }
}
