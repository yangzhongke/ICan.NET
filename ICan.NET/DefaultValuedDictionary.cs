using System;
using System.Collections;
using System.Collections.Generic;

namespace ICan.NET
{
    /// <summary>
    /// A Dictionary that provide a default value for the missing key.
    /// Usage 1:
    /// DefaultValuedDictionary<string,int> dict = new (0);
    /// dict["yzk"]++;
    /// Assert.AreEqual(dict["yzk"], 1);
    /// 
    /// Usage 2:
    /// DefaultValuedDictionary<int, int> dict = new(key => key*2);
    /// Assert.AreEqual(dict[1], 2);
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class DefaultValuedDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private readonly IDictionary<TKey, TValue> dictionary;
        private readonly Func<TKey, TValue> defaultValueProvider;

        public DefaultValuedDictionary(TValue defaultValue)
        {
            this.dictionary = new Dictionary<TKey,TValue>();
            this.defaultValueProvider = (key) => defaultValue;
        }

        public DefaultValuedDictionary(Func<TKey, TValue> defaultValueProvider)
        {
            this.dictionary = new Dictionary<TKey, TValue>();
            this.defaultValueProvider = defaultValueProvider;
        }

        public TValue this[TKey key]
        {
            get
            {
                if (dictionary.TryGetValue(key, out TValue value))
                {
                    return value;
                }
                return defaultValueProvider(key);
            }
            set { dictionary[key] = value; }
        }

        public int Count => dictionary.Count;
        public bool IsReadOnly => dictionary.IsReadOnly;
        public ICollection<TKey> Keys => dictionary.Keys;
        public ICollection<TValue> Values => dictionary.Values;

        public void Add(TKey key, TValue value)
        {
            dictionary.Add(key, value);
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            dictionary.Add(item);
        }

        public void Clear()
        {
            dictionary.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return dictionary.Contains(item);
        }

        public bool ContainsKey(TKey key)
        {
            return dictionary.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            dictionary.CopyTo(array, arrayIndex);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return dictionary.GetEnumerator();
        }

        public bool Remove(TKey key)
        {
            return dictionary.Remove(key);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return dictionary.Remove(item);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return dictionary.TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
