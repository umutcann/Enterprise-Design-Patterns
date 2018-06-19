using CF.Cache.Infrastucture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Cache.Strategy.Memory
{
    public class MemoryStrategy : ICacheStrategy
    {
       
        private static MemoryStrategy _instance;
        private static object _lockObject = new object();

        public static MemoryStrategy Instance
        {
            get
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new MemoryStrategy();
                    }
                    return _instance;
                }

            }
        }
        private Dictionary<string, object> _cacheList;

        private MemoryStrategy()
        {
            _cacheList = new Dictionary<string, object>();
        }


        public void AddToCache (string key, object value)
        {
            if(_cacheList.ContainsKey(key))
            {
                throw new Exception("Cache already defined");
            }
            _cacheList.Add(key, value);

        }


        public void RemoveFromCache(string key)
        {
            if (!_cacheList.ContainsKey(key))
            {
                throw new Exception("Cache was not defined");
            }
            _cacheList.Remove(key);

        }

        public object Get(String key)
        {
            if (!_cacheList.ContainsKey(key))
            {
                throw new Exception("Cache was not defined");
            }
            return _cacheList[key];
        }

        public bool CheckKey(string key)
        {
            return _cacheList.ContainsKey(key);
        }
    }
}
