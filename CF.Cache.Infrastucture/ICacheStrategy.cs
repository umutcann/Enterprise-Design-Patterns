using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Cache.Infrastucture
{
    public interface ICacheStrategy
    {
        void AddToCache(string key, object value);
        void RemoveFromCache(string key);
        object Get(string key);
        bool CheckKey(string key);

    }
}
