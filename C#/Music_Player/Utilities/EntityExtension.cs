using Music_Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Utilities
{
    public static class EntityExtension
    {
        public static string GetDetails(this BaseEntity entity)
        {
            return entity.ToString();
        }
    }
}
