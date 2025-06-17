using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlingLibrary
{
    public class CacheProvider : ICacheProvider
    {

        private MemoryCache cache; // The MemoryCache instance used for caching.

        private string _keyValue; // The key value associated with the cached data.
        private object _data; // The data to be cached.
        private int _dataLifeTimeMinut; // The lifetime of the cached data in minutes.

        private const int DefaultDataLifeTimeMinut = 10; // Default data lifetime in minutes.

        /// <summary>
        /// Gets or sets the lifetime of the cached data in minutes.
        /// If set to a negative value, the default lifetime will be used.
        /// </summary>
        public int DataLifeTimeMinut
        {
            get { return _dataLifeTimeMinut; }
            set
            {
                if (value < 0) _dataLifeTimeMinut = DefaultDataLifeTimeMinut;
                else _dataLifeTimeMinut = value;
            }
        }

        /// <summary>
        /// Gets or sets the key value associated with the cached data.
        /// Checks for null or empty values before setting.
        /// </summary>
        public string KeyValue
        {
            get { return _keyValue; }
            set
            {
                _keyValue = ChekStringValue(value);
            }
        }

        /// <summary>
        /// Gets or sets the data to be cached.
        /// </summary>
        public object Data
        {
            get { return _data; }
            set
            {
                _data = value;
            }
        }



        /// <summary>
        /// Initializes a new instance of the CacheProvider class with the specified parameters.
        /// </summary>
        /// <param name="name">The name associated with the cache instance.</param>
        /// <param name="keyValue">The key value associated with the cached data.</param>
        /// <param name="data">The data to be cached.</param>
        /// <param name="dataLifeTimeMinut">The lifetime of the cached data in minutes (default is 10 minutes).</param>
        public CacheProvider(string name, string keyValue, object data, int dataLifeTimeMinut = DefaultDataLifeTimeMinut)
        {

            
            cache = new MemoryCache(ChekStringValue(name));
            KeyValue = keyValue;
            Data = data;
            DataLifeTimeMinut = dataLifeTimeMinut;
        }


        /// <summary>
        /// Adds the data to the cache if the key value is not already present.
        /// </summary>
        /// <returns>True if the data was successfully added to the cache; otherwise, false.</returns>

        public bool AddDataToCache()
        {
            if (!cache.Contains(_keyValue)) return cache.Add(this._keyValue, _data, DateTimeOffset.Now.AddMinutes(_dataLifeTimeMinut));
            
            return false;
            
        }


        /// <summary>
        /// Gets cached data of type T using the specified key value.
        /// </summary>
        /// <typeparam name="T">The type of the cached data.</typeparam>
        /// <returns>The cached data of type T.</returns>

        public T GetData<T>()
        {
            return (T)cache.Get(this._keyValue);
        }


        /// <summary>
        /// Clears the cached data associated with the specified key value.
        /// Throws an exception if the key value is not found in the cache.
        /// </summary>
        /// <param name="keyValue">The key value to clear from the cache.</param>
        public void ClearKeyValueData(string keyValue)
        {
            
            if(!cache.Contains(keyValue))
                cache.Remove(keyValue);
            throw new Exception("cannot find the key value");
        }


        /// <summary>
        /// Clears the entire cache memory.
        /// </summary>
        public void ClearCacheMemory()
        {
            cache.Dispose();
        }

        /// <summary>
        /// Checks if a string value is null or empty; throws an exception if it is.
        /// </summary>
        /// <param name="value">The string value to check.</param>
        /// <returns>The input value if not null or empty.</returns>
        private string ChekStringValue(string value)
        {
            return !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Cannot be null or empty.");
        }


    }
}
