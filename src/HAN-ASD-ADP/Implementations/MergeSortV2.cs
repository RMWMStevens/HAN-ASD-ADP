using System;
using System.Threading.Tasks;

namespace HAN_ASD_ADP.Implementations;

public class MergeSortV2
{
    public static void Sort<T>(T[] inputArray)
        where T : IComparable<T>
    {
        if (inputArray.Length < 2)
            return;
        T[] tmpArray = new T[inputArray.Length];
        Sort(inputArray, tmpArray, 0, inputArray.Length - 1);
    }

    public static void SortAsync<T>(T[] inputArray)
        where T : IComparable<T>
    {
        if (inputArray.Length < 2)
            return;
        T[] tmpArray = new T[inputArray.Length];
        SortAsync(inputArray, tmpArray, 0, inputArray.Length - 1).GetAwaiter().GetResult();
    }

    public static void SortParallel<T>(T[] inputArray)
    where T : IComparable<T>
    {
        if (inputArray.Length < 2)
            return;
        T[] tmpArray = new T[inputArray.Length];
        SortParallel(inputArray, tmpArray, 0, inputArray.Length - 1);
    }

    private static void Sort<T>(T[] inputArray, T[] tmpArray, int left, int right)
        where T : IComparable<T>
    {
        if (left < right)
        {
            int center = (left + right) / 2;
            Sort(inputArray, tmpArray, left, center);
            Sort(inputArray, tmpArray, center + 1, right);
            Merge(inputArray, tmpArray, left, center, right);
        }
    }

    private static async Task SortAsync<T>(T[] inputArray, T[] tmpArray, int left, int right)
        where T : IComparable<T>
    {
        if (left < right)
        {
            int center = (left + right) / 2;
            await Task.WhenAll(
                SortAsync(inputArray, tmpArray, left, center),
                SortAsync(inputArray, tmpArray, center + 1, right)
            );
            Merge(inputArray, tmpArray, left, center, right);
        }
    }

    private static void SortParallel<T>(T[] inputArray, T[] tmpArray, int left, int right)
        where T : IComparable<T>
    {
        if (left < right)
        {
            int center = (left + right) / 2;
            Parallel.Invoke(
                () => SortParallel(inputArray, tmpArray, left, center),
                () => SortParallel(inputArray, tmpArray, center + 1, right));
            Merge(inputArray, tmpArray, left, center, right);
        }
    }

    private static void Merge<T>(T[] inputArray, T[] tmpArray, int left, int center, int right) where T : IComparable<T>
    {
        int leftIndex = left;
        int rightIndex = center + 1;
        int tmpIndex = left;

        // Merge the two sorted halves into a temporary array
        while (leftIndex <= center && rightIndex <= right)
        {
            if (inputArray[leftIndex].CompareTo(inputArray[rightIndex]) <= 0)
            {
                tmpArray[tmpIndex] = inputArray[leftIndex];
                leftIndex++;
            }
            else
            {
                tmpArray[tmpIndex] = inputArray[rightIndex];
                rightIndex++;
            }
            tmpIndex++;
        }

        while (leftIndex <= center)
        {
            tmpArray[tmpIndex] = inputArray[leftIndex];
            leftIndex++;
            tmpIndex++;
        }

        while (rightIndex <= right)
        {
            tmpArray[tmpIndex] = inputArray[rightIndex];
            rightIndex++;
            tmpIndex++;
        }

        for (int i = left; i <= right; i++)
        {
            inputArray[i] = tmpArray[i];
        }
    }
}