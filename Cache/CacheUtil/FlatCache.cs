﻿using System;
 using System.Collections.Generic;
 using System.Runtime.Caching;
 using Entities;

 namespace Cache.CacheUtil
{
    public class FlatCache
    {
        private int _cachingTime = 10;
        
        public void AddFlat(Flat flat)
        {
            var memoryCache = MemoryCache.Default;
            List<Flat> cached = memoryCache.Get("allFlats") as List<Flat>;
            cached?.Add(flat);
            memoryCache.Set("allFlats", cached, DateTime.Now.AddMinutes(_cachingTime));
        }

        public void Delete(int id)
        {
            var memoryCache = MemoryCache.Default;
            List<Flat> cached = memoryCache.Get("allFlats") as List<Flat>;
            var deleted = cached?.Find(flat => flat.IdFlat == id);
            if (deleted != null)
            {
                cached.Remove(deleted);
                memoryCache.Set("allFlats", cached, DateTime.Now.AddMinutes(_cachingTime));
            }
        }
        public List<Flat> GetAll()
        {
            var memoryCache = MemoryCache.Default;
            return memoryCache.Get("allFlats") as List<Flat>;
        }
 
        public void AddListOfFLats(List<Flat> flatList)
        {
            var memoryCache = MemoryCache.Default;
            if (memoryCache.Get("allFlats") is List<Flat>)
            {
                memoryCache.Set("allFlats", flatList, DateTime.Now.AddMinutes(_cachingTime));
            }
            else
            {
                memoryCache.Add("allFlats", flatList, DateTime.Now.AddMinutes(_cachingTime));
            }
        }
    }
}