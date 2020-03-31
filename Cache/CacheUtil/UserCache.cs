using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using Entities;

namespace Cache.CacheUtil
{
    public class UserCache
    {
        private int _cachingTime = 10;
        
        public User GetUser(int id)
        {
            var memoryCache = MemoryCache.Default;
            return memoryCache.Get(id.ToString()) as User;
        }
 
        public void AddUser(User user)
        {
            var memoryCache = MemoryCache.Default;
            if (memoryCache.Get(user.IdUser.ToString()) is User)
            {
               memoryCache.Set(user.IdUser.ToString(), user, DateTime.Now.AddMinutes(_cachingTime));
            }
            else
            {
                memoryCache.Add(user.IdUser.ToString(), user, DateTime.Now.AddMinutes(_cachingTime));
            }
        }

        public void DeleteUser(int id)
        {
            var memoryCache = MemoryCache.Default;
            if (memoryCache.Contains(id.ToString()))
            {
                memoryCache.Remove(id.ToString());
            }
        }
        
        public List<User> GetListOfUsers()
        {
            var memoryCache = MemoryCache.Default;
            return memoryCache.Get("allUsers") as List<User>;
        }
 
        public void AddListOfUsers(List<User> userList)
        {
            var memoryCache = MemoryCache.Default;
            if (memoryCache.Get("allUsers") is List<User>)
            {
                memoryCache.Set("allUsers", userList, DateTime.Now.AddMinutes(_cachingTime));
            }
            else
            {
                memoryCache.Add("allUsers", userList, DateTime.Now.AddMinutes(_cachingTime));
            }
        }
        
    }
}