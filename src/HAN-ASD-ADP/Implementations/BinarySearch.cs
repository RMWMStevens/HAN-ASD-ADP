using System;
using System.Collections.Generic;

namespace HAN_ASD_ADP.Implementations;

public class BinarySearch<T> where T : IComparable<T>
{
    public List<T> list { get; set; }

    public BinarySearch()
    {
        list = new List<T>();
        list.Sort();
    }

    public void Add(T item)
    {
        list.Add(item);
        list.Sort();
    }

    public void RemoveAt(int index)
    {
        list.RemoveAt(index);
        list.Sort();
    }

    public int IndexOfLinearSearch(T item)
    {
        return list.IndexOf(item);
    }

    public int IndexOfBinarySearchRecursive(T searchedItem)
    {
        return IndexOfBinarySearchRecursive(list, 0, list.Count - 1, searchedItem);
    }

    public int IndexOfBinarySearchRecursive(List<T> sortedList, int left, int right, T searchedItem)
    {
        if (right >= left)
        {
            int mid = left + (right - left) / 2;
            int comparisonResult = searchedItem.CompareTo(sortedList[mid]);
            if (comparisonResult < 0)
            {
                return IndexOfBinarySearchRecursive(sortedList, left, mid - 1, searchedItem);
            }
            else if (comparisonResult > 0)
            {
                return IndexOfBinarySearchRecursive(sortedList, mid + 1, right, searchedItem);
            }
            return mid;
        }
        else
        {
            return -1;
        }
    }
}
