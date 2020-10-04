﻿using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using Entities;

namespace Cache.CacheUtil
{
    public class CottageCache
    {
        private int _cachingTime = 10;
        
        public void AddCottage(Cottage cottage)
        {
            var memoryCache = MemoryCache.Default;
            if (memoryCache.Get(cottage.IdCottage.ToString()) is Cottage)
            {
               memoryCache.Set(cottage.IdCottage.ToString(), cottage, DateTime.Now.AddMinutes(_cachingTime));
            }
            else
            {
                memoryCache.Add(cottage.IdCottage.ToString(), cottage, DateTime.Now.AddMinutes(_cachingTime));
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
        
        public List<Cottage> GetAll()
        {
            var memoryCache = MemoryCache.Default;
            return memoryCache.Get("allCottages") as List<Cottage>;
        }
 
        public void AddListOfCottages(List<Cottage> cottageList)
        {
            var memoryCache = MemoryCache.Default;
            if (memoryCache.Get("allCottages") is List<Cottage>)
            {
                memoryCache.Set("allCottages", cottageList, DateTime.Now.AddMinutes(_cachingTime));
            }
            else
            {
                memoryCache.Add("allCottages", cottageList, DateTime.Now.AddMinutes(_cachingTime));
            }
        }
        
    }
}