using Music_Player.Models;
using Music_Player.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Factories
{
    public class SongFactory : ISongFactory
    {
        //Concrete Factory Implementation
        public ISongRepository<T> GetSongRepo<T>() where T : BaseEntity, new()
        {
            return new SongRepositoryImpl<T>();
        }

    }
}
