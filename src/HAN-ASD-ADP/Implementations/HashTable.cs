using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace HAN_ASD_ADP.Implementations
{
    public class HashTable<TKey, TValue>
    {
        private readonly int[] sizes = { 11, 23, 47, 97, 199, 401, 809, 1619, 3251, 6521, 13049, 26099, 104459, 208927 };
        private KeyValuePair<TKey, TValue>[] table;
        private int tableSize;
        private int inUse = 0;

        public HashTable(int tableSize = 11)
        {
            SetTableSize(tableSize);
            table = new KeyValuePair<TKey, TValue>[tableSize];
        }

        public void Add(TKey key, TValue value)
        {
            int index = HashFunction(key);
            while (table[index].Key != null)
            {
                if (table[index].Key.Equals(key))
                {
                    throw new DuplicateNameException("Key already in use");
                }
                else
                {
                    index = (index + 1) % table.Length;
                }
            }
            table[index] = new KeyValuePair<TKey, TValue>(key, value);
            inUse++;
            if (inUse > tableSize / 2)
            {
                ReSize();
            }
        }
        public (KeyValuePair<TKey, TValue>, int index) Get(TKey key)
        {
            int index = HashFunction(key);

            while (table[index].Key != null)
            {
                if (table[index].Key.Equals(key))
                {
                    return (table[index], index);
                }

                index = (index + 1) % table.Length;
            }

            return default;
        }

        public void Remove(TKey key)
        {
            table[Get(key).index] = default;
        }

        private int GetNextTableSize()
        {
            for (int i = 0; i < sizes.Length - 1; i++)
            {
                if (sizes[i] == tableSize)
                {
                    return sizes[i + 1];
                }
            }
            throw new IndexOutOfRangeException("Cannot increase table size any further");
        }
        private int GetPreviousTableSize()
        {
            for (int i = sizes.Length; i > 0; i--)
            {
                if (sizes[i] == tableSize)
                {
                    return sizes[i - 1];
                }
            }
            return sizes[0];
        }

        private void ReSize()
        {
            var copiedTable = table;
            tableSize = GetNextTableSize();
            table = new KeyValuePair<TKey, TValue>[tableSize];
            inUse = 0;
            for (int i = 0; i < copiedTable.Length; i++)
            {
                if (copiedTable[i].Key != null)
                {
                    Add(copiedTable[i].Key, copiedTable[i].Value);
                }
            }
        }

        private int HashFunction(TKey key)
        {
            string stringKey = key.ToString();
            int value = 0;

            for (int i = 0; i < stringKey.Length; i++)
            {
                value += (i + 1) * Convert.ToByte(stringKey[i]);
            }

            return value % tableSize;
        }

        private void SetTableSize(int value)
        {
            if (sizes.Contains(value))
            {
                tableSize = value;
            }
            else
            {
                throw new ArgumentException("TableSize must be among the prime numbers of sizes[]");
            }
        }
    }
}
