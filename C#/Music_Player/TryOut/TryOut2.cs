using Music_Player.Factories;
using Music_Player.Models;
using Music_Player.Repository;
using Music_Player.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.TryOut
{
    public class TryOut2
    {
        public void Run(SongFactory factory)
        {
            
            ISongRepository<Artist> repo = factory.GetSongRepo<Artist>();
            repo.Add(new Artist { Id = 1, Name="The Beatles", Gender=Gender.Male, Genre="Rock", YearFormed = 1960, Country = "UK", SocialSite = "Multi-Media", Description = "Rock Band" });
            repo.AddRange(new Artist[]
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
            repo.Get()
                .ToList()
                .ForEach(p => Console.WriteLine(p.GetDetails()));
            //Update
            Console.WriteLine("            Updated Artists:     ");
            Console.WriteLine();
            var a = repo.Get(5);
            a.YearFormed = 2015;
            repo.Get()
                .ToList()
                .ForEach(p => Console.WriteLine(p.GetDetails()));
            //Delete
            Console.WriteLine("            After removal:     ");
            Console.WriteLine();
            repo.Delete(5);
            repo.Get()
                .ToList()
                .ForEach(p => Console.WriteLine(p.GetDetails()));
        }
    }
}
