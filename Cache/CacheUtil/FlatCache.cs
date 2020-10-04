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
            if (memoryCache.Get(flat.IdFlat.ToString()) is Flat)
            {
                memoryCache.Set(flat.IdFlat.ToString(), flat, DateTime.Now.AddMinutes(_cachingTime));
            }
            else
            {
                memoryCache.Add(flat.IdFlat.ToString(), flat, DateTime.Now.AddMinutes(_cachingTime));
            }
        }

        public void Delete(int id)
        {
            var memoryCache = MemoryCache.Default;
            if (memoryCache.Contains(id.ToString()))
            {
                memoryCache.Remove(id.ToString());
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