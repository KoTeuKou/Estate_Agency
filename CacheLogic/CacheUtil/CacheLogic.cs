﻿using System;
using System.Collections.Generic;
 using System.Linq;
 using System.Runtime.Caching;
using Entities;

namespace Cache.CacheUtil
{
    public class CacheLogic
    {
        private readonly int _cachingTime = 10;
        private static readonly MemoryCache _memoryCache = MemoryCache.Default;
        
        public T Add<T>(Func<T> action, string key)
        {
            var item = action();
            var cached = _memoryCache.Get(key) as List<T>;
            cached.Add(item);
            _memoryCache.Set(key, cached, DateTime.Now.AddMinutes(_cachingTime));
            return item;
        }

        public bool Delete<T>(int id, Func<bool> action, string key)
        {
            var isDeleted = action();
            if (isDeleted)
            {
                var cached = _memoryCache.Get(key) as List<T>;
            }
            return isDeleted;
        }
        
        public List<T> GetAll<T>(Func<List<T>> action, string key)
        {
            if (_memoryCache.Contains(key))
            {
                return _memoryCache.Get(key) as List<T>;
            }

            var listFromDb = action();
            _memoryCache.Add(key, listFromDb, DateTime.Now.AddMinutes(_cachingTime));
            return listFromDb;
        }
        
        public List<T> SetAll<T>(Func<List<T>> action, string key)
        {
            var filteredCollection = action();
            if (_memoryCache.Contains(key))
            {
                _memoryCache.Set(key, filteredCollection, DateTime.Now.AddMinutes(_cachingTime));
            }
            else
            {
                _memoryCache.Add(key, filteredCollection, DateTime.Now.AddMinutes(_cachingTime));
            }

            return filteredCollection;
        }
    }
}