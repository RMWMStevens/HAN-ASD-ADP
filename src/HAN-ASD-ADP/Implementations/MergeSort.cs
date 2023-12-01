using System;
using System.Threading.Tasks;

namespace HAN_ASD_ADP.Implementations;

public static class MergeSort
{
    public static void Sort<T>(T[] inputArray) where T : IComparable<T>
    {
        if (inputArray.Length < 2)
            return;

        var (leftHalf, rightHalf) = SortAlgorithm(inputArray);

        Sort(leftHalf);
        Sort(rightHalf);

        Merge(inputArray, leftHalf, rightHalf);
    }

    public static void SortParallel<T>(T[] inputArray) where T : IComparable<T>
    {
        if (inputArray.Length < 2)
            return;

        var (leftHalf, rightHalf) = SortAlgorithm(inputArray);

        Parallel.Invoke(
            () => SortParallel(leftHalf),
            () => SortParallel(rightHalf)
            );

        Merge(inputArray, leftHalf, rightHalf);
    }

    public static void SortAsync<T>(T[] inputArray) where T : IComparable<T>
    {
        if (inputArray.Length < 2)
            return;

        SortAsyncTask(inputArray).GetAwaiter().GetResult();
    }

    private static async Task SortAsyncTask<T>(T[] inputArray) where T : IComparable<T>
    {
        if (inputArray.Length < 2)
            return;

        var (leftHalf, rightHalf) = SortAlgorithm(inputArray);

        await Task.WhenAll(
            SortAsyncTask(leftHalf),
            SortAsyncTask(rightHalf));

        Merge(inputArray, leftHalf, rightHalf);
    }

    public static (T[] LeftHalf, T[] RightHalf) SortAlgorithm<T>(T[] inputArray)
    {
        int inputLength = inputArray.Length;
        int midIndex = inputArray.Length / 2;
        T[] leftHalf = new T[midIndex];
        T[] rightHalf = new T[inputLength - midIndex];

        for (int i = 0; i < midIndex; i++)
        {
            leftHalf[i] = inputArray[i];
        }

        for (int i = midIndex; i < inputLength; i++)
        {
            rightHalf[i - midIndex] = inputArray[i];
        }
        return (leftHalf, rightHalf);
    }

    private static void Merge<T>(T[] inputArray, T[] leftHalf, T[] rightHalf) where T : IComparable<T>
    {
        int leftLength = leftHalf.Length;
        int rightLength = rightHalf.Length;
        int i = 0; // leftHalf
        int j = 0; // rightHalf
        int k = 0; // merged

        while (i < leftLength && j < rightLength)
        {
            if (leftHalf[i].CompareTo(rightHalf[j]) <= 0)
            {
                inputArray[k] = leftHalf[i];
                i++;
            }
            else
            {
                inputArray[k] = rightHalf[j];
                j++;
            }
            k++;
        }

        while (i < leftLength)
        {
            inputArray[k] = leftHalf[i];
            i++;
            k++;
        }

        while (j < rightLength)
        {
            inputArray[k] = rightHalf[j];
            j++;
            k++;
        }
    }
}