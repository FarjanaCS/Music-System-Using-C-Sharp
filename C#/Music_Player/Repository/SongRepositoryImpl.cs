using Music_Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Repository
{
    //Concrete Implementation of The Repository Using Interface
    public class SongRepositoryImpl<T> : ISongRepository<T> where T : BaseEntity, new()
    {
        private readonly List<T> music = new List<T>();
        public IEnumerable<T> Get()
        {
            return music;
        }
        public T Get(int id)
        {
            return music.First(x => x.Id == id);
        }
        public void Add(T entity)
        {
            music.Add(entity); ;
        }

        public void AddRange(IEnumerable<T> entities)
        {
            music.AddRange(entities);
        }

        public void Delete(int id)
        {
            var item = music.First(x => x.Id == id);
            music.Remove(item);
        }
        public void Update(T entity)
        {
            int index = music.FindIndex(x => x.Id == entity.Id);
            music.RemoveAt(index);
            music.Insert(index, entity);
        }
        

     
    }
}
