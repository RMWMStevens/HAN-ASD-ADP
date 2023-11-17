using System;

namespace HAN_ASD_ADP.Implementations;

public class DynamicArray<T>
{
    private const int DefaultCapacity = 4;
    private T[] array;

    public DynamicArray()
    {
        array = new T[DefaultCapacity];
    }

    public int Count { get; private set; } = 0;

    public void Add(T item)
    {
        if (Count == array.Length)
        {
            ExpandArray();
        }

        array[Count] = item;
        Count++;
    }

    public T Get(int index)
    {
        return array[index];
    }

    public int IndexOf(T value)
    {
        for (int i = 0; i < Count; i++)
        {
            if (array[i].Equals(value))
            {
                return i;
            };
        }
        return -1;
    }

    public void Remove(T value)
    {
        for (int index = 0; index < Count; index++)
        {
            if (array[index].Equals(value))
                RemoveAt(index);
        }
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new IndexOutOfRangeException();
        }

        for (int i = index; i < Count - 1; i++)
        {
            array[i] = array[i + 1];
        }

        Count--;

        if (Count < array.Length / 2 && array.Length > DefaultCapacity)
        {
            ShrinkArray();
        }
    }

    public void Set(int index, T value)
    {
        array[index] = value;
    }

    public bool Contains(T value)
    {
        for (int i = 0; i < Count; i++)
        {
            if (array[i].Equals(value))
            {
                return true;
            }
        }
        return false;
    }

    private void ResizeArray(int newCapacity)
    {
        T[] newArray = new T[newCapacity];
        for (int i = 0; i < Count; i++)
        {
            newArray[i] = array[i];
        }
        array = newArray;
    }

    private void ExpandArray()
    {
        int newCapacity = array.Length * 2;
        ResizeArray(newCapacity);
    }

    private void ShrinkArray()
    {
        int newCapacity = array.Length / 2;
        ResizeArray(newCapacity);
    }
}