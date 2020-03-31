using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using Entities;

namespace Cache.CacheUtil
{
    public class AwardCache
    {
        private int _cachingTime = 10;
        
        public Award GetAward(int id)
        {
            var memoryCache = MemoryCache.Default;
            return memoryCache.Get(id.ToString()) as Award;
        }
 
        public void AddAward(Award award)
        {
            var memoryCache = MemoryCache.Default;
            if (memoryCache.Get(award.IdAward.ToString()) is Award)
            {
                memoryCache.Set(award.IdAward.ToString(), award, DateTime.Now.AddMinutes(_cachingTime));
            }
            else
            {
                memoryCache.Add(award.IdAward.ToString(), award, DateTime.Now.AddMinutes(_cachingTime));
            }
        }

        public void DeleteAward(int id)
        {
            var memoryCache = MemoryCache.Default;
            if (memoryCache.Contains(id.ToString()))
            {
                memoryCache.Remove(id.ToString());
            }
        }
        public List<Award> GetListOfAwards()
        {
            var memoryCache = MemoryCache.Default;
            return memoryCache.Get("allAwards") as List<Award>;
        }
 
        public void AddListOfAwards(List<Award> awardList)
        {
            var memoryCache = MemoryCache.Default;
            if (memoryCache.Get("allAwards") is List<Award>)
            {
                memoryCache.Set("allAwards", awardList, DateTime.Now.AddMinutes(_cachingTime));
            }
            else
            {
                memoryCache.Add("allAwards", awardList, DateTime.Now.AddMinutes(_cachingTime));
            }
        }
    }
}