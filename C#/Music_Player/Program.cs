using Music_Player.Factories;
using Music_Player.Method;
using Music_Player.Models;
using Music_Player.Repository;
using Music_Player.TryOut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TryOut1 tryOut1 = new TryOut1(new SongFactory());
            tryOut1.Run();
            IMusicPlayerMethod musicPlayerMethod = new MusicPlayerMethod();
            musicPlayerMethod.Stop();
            Console.WriteLine();
            Console.WriteLine("          Overview Of Artists:");
            TryOut2 di2 = new TryOut2();
            di2.Run(new SongFactory());
            Console.WriteLine();
            Console.WriteLine("..............Another Way to Test.............");
            Console.WriteLine();
            ISongFactory songFactory = new SongFactory();
            TryOut3 tryOut3= new TryOut3(songFactory.GetSongRepo<Song>());
            tryOut3.RunSong();
            Console.WriteLine();
            Console.WriteLine("..............Another Way to Test.............");
            Console.WriteLine();
            TryOut4 tryOut4 = new TryOut4(songFactory.GetSongRepo<Artist>());
            tryOut4.Run();
            Console.ReadLine();
        }
    }
}
