using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Threading.Tasks;

namespace CoreWebApp.Cache
{
    public class CacheService 
    {
        #region ICacheProvider Members        

        /// <summary>
        /// Gets a count of cached entries.
        /// </summary>
        public long Count
        {
            get { return Cache.GetCount(); }
        }

        /// <summary>
        /// Gets the list of keys in the current cache.
        /// </summary>
        public IEnumerable<string> Keys
        {
            get { return Cache.Select(kvp => kvp.Key).ToList(); }
        }

        /// <summary>
        /// Gets the cache.
        /// </summary>
        /// <value>
        /// The cache.
        /// </value>
        private static ObjectCache Cache
        {
            get { return MemoryCache.Default; }
        }

        /// <summary>
        /// Gets the specified cached content for the supplied key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>
        /// returns key
        /// </returns>
        public object Get(string key)
        {
            return Cache[key];
        }

        /// <summary>
        /// Sets the specified value in the cache.
        /// </summary>
        /// <param name="key">The key to cache the data against.</param>
        /// <param name="data">The data to be cached.</param>
        /// <param name="cacheTimeInMin">The cache Time In Mins</param>
        public void Set(string key, object data, int cacheTimeInMin)
        {
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTimeOffset.UtcNow.AddMinutes(cacheTimeInMin)
            };
            Cache.Add(new CacheItem(key, data), policy);
        }

        /// <summary>
        /// Determines whether the specified key is set.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>
        ///   <c>true</c> if the specified key is set; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSet(string key)
        {
            return Cache[key] != null;
        }

        /// <summary>
        /// Invalidates the cache relating to the specified key, if key is null or empty then all cache entries are invalidated.
        /// </summary>
        /// <param name="key">The key whose entries require invalidation.</param>
        public void Invalidate(string key = null)
        {
            if (string.IsNullOrEmpty(key))
            {
                var keys = this.Keys;
                foreach (var cacheKey in keys)
                {
                    Cache.Remove(cacheKey);
                }
            }
            else
            {
                Cache.Remove(key);
            }
        }
        #endregion
    }
}
