using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _01._02.HashTableLinkedList___NET
{
    public class HashTable<TKey, TValue> : IHashTable<TKey, TValue>, IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private const int DefaultCapacity = 16;
        private const float DefaultLoadFactory = 0.75f;
        private readonly int initialCapacity;

        private IList<KeyValuePair<TKey, TValue>>[] table;

        public HashTable()
            : this(DefaultCapacity)
        {
        }

        public HashTable(int capacity)
        {
            initialCapacity = capacity;
            table = new IList<KeyValuePair<TKey, TValue>>[capacity];
        }

        public int Count { get; private set; }

        public ICollection<TKey> Keys
        {
            get
            {
                var keys = GetKeys();
                return keys;
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                return GetValue(key);
            }
            set
            {
                Add(key, value);
            }
        }

        public void Add(TKey key, TValue value)
        {
            var chain = FindChain(key, true);

            for (int i = 0; i < chain.Count; i++)
            {
                if (chain[i].Key.Equals(key))
                {
                    chain[i] = new KeyValuePair<TKey, TValue>(key, value);
                    return;
                }
            }

            chain.Add(new KeyValuePair<TKey, TValue>(key, value));
            Count++;
            Expand();
        }

        public bool ContainsKey(TKey key)
        {
            var chain = FindChain(key, false);

            if (chain != null)
            {
                for (int i = 0; i < chain.Count; i++)
                {
                    if (chain[i].Key.Equals(key))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public TValue GetValue(TKey key)
        {
            var chain = FindChain(key, false);

            if (chain != null)
            {
                for (int i = 0; i < chain.Count; i++)
                {
                    if (chain[i].Key.Equals(key))
                    {
                        return chain[i].Value;
                    }
                }
            }

            throw new KeyNotFoundException("The given key was not present in the hash table.");
        }

        public bool Remove(TKey key)
        {
            var chain = FindChain(key, false);

            if (chain != null)
            {
                for (int i = 0; i < chain.Count; i++)
                {
                    if (chain[i].Key.Equals(key))
                    {
                        chain.RemoveAt(i);
                        Count--;
                        return true;
                    }
                }
            }

            return false;
        }

        public void Clear()
        {
            if (table != null)
            {
                table = new IList<KeyValuePair<TKey, TValue>>[initialCapacity];
            }

            Count = 0;
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (var chain in table)
            {
                if (chain != null)
                {
                    foreach (var keyValuePair in chain)
                    {
                        yield return keyValuePair;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private List<TKey> GetKeys()
        {
            var keys = new List<TKey>();

            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] != null)
                {
                    for (int j = 0; j < table[i].Count; j++)
                    {
                        if (table[i][j].Key != null)
                        {
                            keys.Add(table[i][j].Key);
                        }
                    }
                }
            }

            return keys;
        }

        private IList<KeyValuePair<TKey, TValue>> FindChain(TKey key, bool createIfMissing)
        {
            var hash = key.GetHashCode() & int.MaxValue;
            var index = hash % table.Length;

            if (table[index] == null && createIfMissing)
            {
                table[index] = new List<KeyValuePair<TKey, TValue>>();
            }

            return table[index];
        }

        private void Expand()
        {
            var maxLength = (int)(table.Length * DefaultLoadFactory);

            if (Count >= maxLength)
            {
                int newCapacity = table.Length * 2;

                IList<KeyValuePair<TKey, TValue>>[] oldTable = table;
                table = new List<KeyValuePair<TKey, TValue>>[newCapacity];

                foreach (var oldChain in oldTable)
                {
                    if (oldChain != null)
                    {
                        foreach (var keyValuePair in oldChain)
                        {
                            var chain = FindChain(keyValuePair.Key, true);
                            chain.Add(keyValuePair);
                        }
                    }
                }
            }
        }
    }
}
