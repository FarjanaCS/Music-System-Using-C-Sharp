using Music_Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Method
{
    //Method Interface
    public interface IMusicPlayerMethod
    {
        void Play(Song song, Artist artist);
        void Stop();
    }
}
