using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlingLibrary
{
    /// <summary>
    /// Represents an interface for a cache provider responsible for managing data caching.
    /// </summary>
    public interface ICacheProvider
    {
        /// <summary>
        /// Gets or sets the lifetime of the cached data in minutes.
        /// If set to a negative value, the default lifetime will be used.
        /// </summary>
        int DataLifeTimeMinut { get; set; }

        /// <summary>
        /// Gets or sets the key value associated with the cached data.
        /// Checks for null or empty values before setting.
        /// </summary>
        string KeyValue { get; set; }

        /// <summary>
        /// Gets or sets the data to be cached.
        /// </summary>
        object Data { get; set; }

        /// <summary>
        /// Adds the data to the cache if the key value is not already present.
        /// </summary>
        /// <returns>True if the data was successfully added to the cache; otherwise, false.</returns>
        bool AddDataToCache();

        /// <summary>
        /// Gets cached data of type T using the specified key value.
        /// </summary>
        /// <typeparam name="T">The type of the cached data.</typeparam>
        /// <returns>The cached data of type T.</returns>
        T GetData<T>();

        /// <summary>
        /// Clears the cached data associated with the specified key value.
        /// Throws an exception if the key value is not found in the cache.
        /// </summary>
        /// <param name="keyValue">The key value to clear from the cache.</param>
        void ClearKeyValueData(string keyValue);

        /// <summary>
        /// Clears the entire cache memory.
        /// </summary>
        void ClearCacheMemory();
    }

}
