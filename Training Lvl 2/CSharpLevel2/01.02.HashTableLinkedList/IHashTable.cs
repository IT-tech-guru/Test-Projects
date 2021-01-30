using System;
using System.Collections.Generic;
using System.Text;

namespace _01._02.HashTableLinkedList
{
    public interface IHashTable<TKey, TValue>
    {
        int Count { get; }

        TValue this[TKey key] { get; set; }

        void Add(TKey key, TValue value);

        TValue GetValue(TKey key);

        bool Remove(TKey key);

        void Clear();
    }
}
