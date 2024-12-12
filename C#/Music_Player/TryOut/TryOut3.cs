using Music_Player.Models;
using Music_Player.Repository;
using Music_Player.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.TryOut
{
    public class TryOut3
    {
        
        private ISongRepository <Song> Repo;
        public TryOut3(ISongRepository<Song> repo)
        {
            this.Repo = repo;
        }
       
        public void RunSong()
        {
            this.Repo.Add(new Song { Id = 1, Title = "Let It Be", Genre = "Rock", ReleaseDate = new DateTime(1970, 05, 08), Duration = TimeSpan.FromMinutes(4.1), Composer = "jhon Lennon", Language = "English", Album = "Let It Be" });
            Repo.AddRange(new Song[] {
                new Song { Id = 2,Title = "Dangerous", Genre="Pop", ReleaseDate =new DateTime(1991,02,05),Duration= TimeSpan.FromMinutes(7.1), Composer="Micheal Jackson", Language="English", Album="Dangerous" },
                new Song { Id = 3,Title = "Popular", Genre="Pop", ReleaseDate =new DateTime(2021,04,21),Duration= TimeSpan.FromMinutes(3.4) , Composer="Madona", Language="English", Album="The Highlights"},
                new Song { Id = 4,Title = "Lover",   Genre="Pop", ReleaseDate =new DateTime(2019,09,16),Duration= TimeSpan.FromMinutes(3.9), Composer="Tylor Swift", Language="English", Album="Lover" },
                new Song { Id = 5,Title = "Mic Drop", Genre="K-Pop", ReleaseDate =new DateTime(2017,09,07),Duration= TimeSpan.FromMinutes(4.3), Composer="Steve Aoki, RM", Language="English, Korean", Album="Love Yourself" },
                new Song { Id = 6,Title = "How You Like That", Genre="K-Pop", ReleaseDate =new DateTime(2020,02,15),Duration= TimeSpan.FromMinutes(3.5) , Composer="Balc Pink", Language="English, Korean", Album="The Album"},
                new Song { Id = 7,Title = "Texas Hold 'Em", Genre="R&B(Rhythm and Blues)", ReleaseDate =new DateTime(2024,06,07),Duration= TimeSpan.FromMinutes(4.8), Composer="Beyonce`", Language="English", Album="Texus" },
                new Song { Id = 8,Title = "Venom", Genre="Rap", ReleaseDate =new DateTime(2018,08,05),Duration= TimeSpan.FromMinutes(4.4), Composer="Eminem", Language="English", Album="Owner" },
                new Song { Id = 9,Title = "Alone Pt. ||", Genre="DJ", ReleaseDate =new DateTime(2020,03,27),Duration= TimeSpan.FromMinutes(5), Composer="Alan Walker", Language="English", Album="Hide" },
                new Song { Id = 10,Title = "One More chance",Genre="Hip Hop", ReleaseDate =new DateTime(1994,01,17),Duration= TimeSpan.FromMinutes(4.2), Composer="Notorious B.I.G.", Language="English", Album="The Music" }
            });
            //Get
            this.Repo.Get()
                .ToList()
                .ForEach(x => { Console.WriteLine(x); });
            Console.WriteLine();
            //Remove
            Console.WriteLine("            After Removal:     ");
            Console.WriteLine();
            Repo.Delete(1);
            Repo.Get()
               .ToList()
               .ForEach(b => Console.WriteLine($"{b.ToString()}"));
            Console.WriteLine();
            //Update
            Console.WriteLine("            Updated Playlist:     ");
            Console.WriteLine();
            var song = Repo.Get(2);
            song.Title = "My Heart Will Go On";
            song.ReleaseDate = new DateTime(1997, 11, 14);
            song.Duration = TimeSpan.FromMinutes(4.7);
            Repo.Update(song);
            Repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"{b.ToString()}"));
            Console.WriteLine();
        }
        
        
    }
}
