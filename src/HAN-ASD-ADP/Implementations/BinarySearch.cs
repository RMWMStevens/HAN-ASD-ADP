using System;
using System.Collections.Generic;

namespace HAN_ASD_ADP.Implementations
{
    public class BinarySearch<T> where T : IComparable<T>
    {
        public List<T> array { get; set; }

        public BinarySearch()
        {
            array = new List<T>();
            array.Sort();
        }

        public void Add(T item)
        {
            array.Add(item);
            array.Sort();
        }

        public void RemoveAt(int index)
        {
            array.RemoveAt(index);
            array.Sort();
        }

        public int IndexOfLinearSearch(T item)
        {
            return array.IndexOf(item);
        }

        public int IndexOfBinarySearchRecursive(T searchedItem)
        {
            return IndexOfBinarySearchRecursive(array, 0, array.Count, searchedItem);
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
}
