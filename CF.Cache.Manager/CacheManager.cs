using CF.Cache.Infrastucture;
using CF.Cache.Strategy.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Cache.Manager
{
    public static class CacheManager
    {
        public static ICacheStrategy Get()
        {
            //TODO : Hangi cache stratejisinden gelececğini belirle
            MemoryStrategy memory = MemoryStrategy.Instance;
            return memory;
            
        }
    }
}
