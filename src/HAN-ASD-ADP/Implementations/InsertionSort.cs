using System;

namespace HAN_ASD_ADP.Implementations;

public static class InsertionSort
{
    public static void Sort<T>(T[] array)
        where T : IComparable
    {
        for (int index = 1; index < array.Length; index++)
        {
            T itemToInsert = array[index];
            int insertIndex = index;

            while (insertIndex > 0 && itemToInsert.CompareTo(array[insertIndex - 1]) < 0)
            {
                array[insertIndex] = array[insertIndex - 1];
                insertIndex--;
            }

            array[insertIndex] = itemToInsert;
        }
    }
}