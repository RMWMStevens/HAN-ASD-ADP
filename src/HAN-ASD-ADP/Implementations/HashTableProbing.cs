using System;
using System.Collections.Generic;
using System.Linq;

namespace HAN_ASD_ADP.Implementations;

public class HashTableProbing<TKey, TValue>
{
    private KeyValuePair<TKey, TValue>[] table;

    private readonly int[] sizes = { 11, 23, 47, 97, 199, 401, 809, 1619, 3251, 6521, 13049, 26099, 104459, 208927 };
    private int tableSize = 0;
    private int inUse = 0;
    private readonly bool linearProbing = false;

    public int Count { get => inUse; }

    public int TableSize { get => tableSize; }

    public HashTableProbing(bool linearProbing = true, int tableSize = 11)
    {
        SetTableSize(tableSize);
        this.linearProbing = linearProbing;
        table = new KeyValuePair<TKey, TValue>[tableSize];
    }

    public void Add(TKey key, TValue value)
    {
        int index = HashFunction(key);
        while (table[index].Key != null)
        {
            if (table[index].Key.Equals(key))
            {
                throw new ArgumentException("Key already in use");
            }
            else
            {
                index = Probe(index);
            }
        }
        table[index] = new KeyValuePair<TKey, TValue>(key, value);
        inUse++;
        if (inUse > tableSize / 2)
        {
            Resize();
        }
    }

    /// <summary>
    /// For testing purposes only.
    /// </summary>
    /// <param name="index">Value of the index.</param>
    /// <returns></returns>
    internal KeyValuePair<TKey, TValue> GetByIndex(int index)
        => table[index];

    public KeyValuePair<TKey, TValue> Get(TKey key)
    {
        int index = HashFunction(key);

        while (table[index].Key != null)
        {
            if (table[index].Key.Equals(key))
            {
                return table[index];
            }

            index = Probe(index);
        }

        throw new KeyNotFoundException("Key was not found.");
    }

    /// <summary>
    /// For testing purposes only.
    /// </summary>
    /// <param name="key">Value of the key.</param>
    /// <returns></returns>
    internal int GetIndex(TKey key)
    {
        int index = HashFunction(key);

        while (table[index].Key != null)
        {
            if (table[index].Key.Equals(key))
            {
                return index;
            }

            index = Probe(index);
        }

        return -1;
    }

    public void Remove(TKey key)
    {
        table[GetIndex(key)] = default;
        inUse--;
        if (sizes[0] != tableSize && inUse < tableSize / 5)
        {
            Resize(false);
        }
    }

    public void Update(TKey key, TValue value)
    {
        table[GetIndex(key)] = new KeyValuePair<TKey, TValue>(key, value);
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

    private void Resize(bool increase = true)
    {
        var tempTable = table;
        if(increase)
        {
            tableSize = GetNextTableSize();
        } else
        {
            tableSize = GetPreviousTableSize();
        }
        table = new KeyValuePair<TKey, TValue>[tableSize];
        inUse = 0;
        for (int i = 0; i < tempTable.Length; i++)
        {
            if (tempTable[i].Key != null)
            {
                Add(tempTable[i].Key, tempTable[i].Value);
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
        if (!sizes.Contains(value))
            throw new KeyNotFoundException("TableSize must be among the prime numbers of sizes[]");

        tableSize = value;
    }

    private int Probe(int index)
    {
        var probe = linearProbing ? index + 1 : (index + 1) * (index + 1);
        return probe % table.Length;
    }
}