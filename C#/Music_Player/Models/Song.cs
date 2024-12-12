using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Models
{
    public class Song:BaseEntity
    {
        //Define Song Class
        public string Title {  get; set; }
        public string Genre {  get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan Duration { get; set; }
        public string Composer { get; set; }
        public string Language { get; set; }
        public string Album { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}, Genre:  {Genre} , Release Date:{ReleaseDate:yyyy-MM-dd}, Duration: {Duration}," +
                $"Composer: {Composer}, Language: {Language},Album:{Album}";
        }
    }
}
