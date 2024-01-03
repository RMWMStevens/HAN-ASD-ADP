using System;
using System.Collections.Generic;

namespace HAN_ASD_ADP.Implementations;

public class HashTableChaining<TKey, TValue>
    where TKey : IEquatable<TKey>
{
    private readonly List<KeyValuePair<TKey, TValue>>[] table;
    private readonly int size;

    public HashTableChaining(int size = 10)
    {
        this.size = size;
        table = new List<KeyValuePair<TKey, TValue>>[size];
        for (int i = 0; i < size; i++)
        {
            table[i] = new();
        }
    }

    public void Add(TKey key, TValue value)
    {
        int index = GetHashIndex(key);
        foreach (var pair in table[index])
        {
            if (pair.Key.Equals(key))
                throw new ArgumentException("Key already in use");
        }
        table[index].Add(new KeyValuePair<TKey, TValue>(key, value));
    }

    public TValue Get(TKey key)
    {
        int index = GetHashIndex(key);
        foreach (var pair in table[index])
        {
            if (pair.Key.Equals(key))
                return pair.Value;
        }
        throw new KeyNotFoundException("Key was not found.");
    }

    public void Delete(TKey key)
    {
        int index = GetHashIndex(key);
        var list = table[index];
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Key.Equals(key))
            {
                list.RemoveAt(i);
                return;
            }
        }
        throw new KeyNotFoundException("Key was not found.");
    }

    public void Update(TKey key, TValue newValue)
    {
        int index = GetHashIndex(key);
        for (int i = 0; i < table[index].Count; i++)
        {
            KeyValuePair<TKey, TValue> pair = table[index][i];
            if (pair.Key.Equals(key))
            {
                table[index][i] = new KeyValuePair<TKey, TValue>(pair.Key, newValue);
                return;
            }
        }
        throw new KeyNotFoundException("Key was not found.");
    }

    private int GetHashIndex(TKey key)
    {
        int hash = key.GetHashCode();
        int index = hash % size;
        return Math.Abs(index);
    }
}