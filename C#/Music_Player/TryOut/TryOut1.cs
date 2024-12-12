using Music_Player.Factories;
using Music_Player.Models;
using Music_Player.Repository;
using Music_Player.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.TryOut
{
    public class TryOut1
    {
        readonly ISongFactory Factory;
        public TryOut1(ISongFactory factory)
        {
            this.Factory = factory;
        }
        public void Run()
        {
            Console.WriteLine("            Favourite Playlist:  ");
            Console.WriteLine();
            ISongRepository<Song> repo = this.Factory.GetSongRepo<Song>();
            repo.Add(new Song { Id = 1, Title = "Let It Be", Genre = "Rock", ReleaseDate = new DateTime(1970, 05, 08), Duration = TimeSpan.FromMinutes(4.1), Composer = "jhon Lennon", Language = "English", Album = "Let It Be" });
            repo.AddRange(new Song[] {
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
            repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"{b.GetDetails()}"));
            Console.WriteLine();

            //Remove
            Console.WriteLine("            After Removal:     ");
            Console.WriteLine();
            repo.Delete(1);
            repo.Get()
               .ToList()
               .ForEach(b => Console.WriteLine($"{b.GetDetails()}"));
            Console.WriteLine();
            //Update
            Console.WriteLine("            Updated Playlist:     ");
            Console.WriteLine();
            var song = repo.Get(2);
            song.Title = "My Heart Will Go On";
            song.ReleaseDate = new DateTime(1997, 11, 14);
            song.Duration = TimeSpan.FromMinutes(4.7);
            repo.Update(song);
            repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"{b.GetDetails()}"));
            Console.WriteLine();
            Console.WriteLine("                 Artists              ");
            ISongRepository<Artist> repos = this.Factory.GetSongRepo<Artist>();
            repos.Add(new Artist { Id = 1, Name = "The Beatles", Gender = Gender.Male, Genre = "Rock", YearFormed = 1960, Country = "UK", SocialSite = "Multi-Media", Description = "Rock Band" });
            repos.AddRange(new Artist[]
            {
                new Artist { Id = 2, Name="Michael Jackson", Gender=Gender.Male, Genre="Pop", YearFormed=1964, Country="USA", SocialSite="Multi-Media", Description="Singer,Song Writer,Dancer"},
                new Artist { Id = 3, Name="Madonna", Genre="Pop" , Gender=Gender.Female ,YearFormed=1979, Country="USA", SocialSite="Instagram, YouTube", Description="Singer,Song Writer,Actress"},
                new Artist { Id = 4, Name="Tylor Swift", Genre="Pop",  Gender=Gender.Female ,YearFormed=2003, Country="USA", SocialSite="Instagram, YouTube", Description="Singer,Song Writer" },
                new Artist { Id = 5, Name="BTS", Genre="K-Pop" ,  Gender=Gender.Male,  YearFormed=2013, Country="South Korea", SocialSite="Weverse,YouTube,Instagram", Description="Singer,Song Writer,Dancer"},
                new Artist { Id = 6, Name="Black Pink", Genre="K-Pop", Gender=Gender.Female, YearFormed=2016, Country="South Korea", SocialSite="Weverse,YouTube,Instagram", Description="Singer,Song Writer,Dancer" },
                new Artist { Id = 7, Name="Beyonce`", Genre="R&B(Rhythm and Blues)" , Gender=Gender.Female , YearFormed=1990, Country="USA", SocialSite="Multi-Media", Description="Singer,Song Writer,Business Woman"},
                new Artist { Id = 8, Name="Eminem", Genre="Rap" ,  Gender=Gender.Male,YearFormed=1988, Country="USA", SocialSite="YouTube", Description="Rapper"},
                new Artist { Id = 9, Name="Alan Walker", Genre="DJ" ,  Gender=Gender.Male,YearFormed=2012, Country="Norway", SocialSite="YouTube, Instagram", Description="DJ, Music Producer"},
                new Artist { Id = 10,Name="Notorious B.I.G.", Genre="Hip Hop", Gender=Gender.Male, YearFormed=1992, Country="USA", SocialSite="Multi-Media", Description="Rapper,Song Writer,Producer"}
            });
            repos.Get()
                .ToList()
                .ForEach(p => Console.WriteLine(p.GetDetails()));
            //Update
            Console.WriteLine("            Updated Artists:     ");
            Console.WriteLine();
            var a = repos.Get(5);
            a.YearFormed = 2015;
            repos.Get()
                .ToList()
                .ForEach(p => Console.WriteLine(p.GetDetails()));
            //Delete
            Console.WriteLine("            After removal:     ");
            Console.WriteLine();
            repos.Delete(5);
            repos.Get()
                .ToList()
                .ForEach(p => Console.WriteLine(p.GetDetails()));
        }

    }
}
