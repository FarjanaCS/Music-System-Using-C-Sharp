using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Models
{
    public enum Gender { Male, Female }
    public class Artist:BaseEntity
    {
        //Artist Class
        
        public string Name {  get; set; }
        public Gender Gender { get; set; }
        public string Genre { get; set; }
        public int YearFormed { get; set; }
        public string Country { get; set; }
        public string SocialSite { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"Id:{Id},  Name: {Name}, Genre: {Genre}, Gender: {Gender},Country: {Country},Debut Year: {YearFormed},Description: {Description}";
        }

    }
}
