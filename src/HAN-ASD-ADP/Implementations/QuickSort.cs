using System;

namespace HAN_ASD_ADP.Implementations;

public static class QuickSort
{
    private static readonly Random random = new();

    public static void SortHigh<T>(T[] array)
        where T : IComparable
        => Sort(array, 0, array.Length - 1, PivotStrategy.High);

    public static void SortMiddle<T>(T[] array)
        where T : IComparable
        => Sort(array, 0, array.Length - 1, PivotStrategy.Middle);

    public static void SortRandom<T>(T[] array)
        where T : IComparable
        => Sort(array, 0, array.Length - 1, PivotStrategy.Random);

    private static void Sort<T>(T[] array, int low, int high, PivotStrategy pivotStrategy)
    where T : IComparable
    {
        if (low >= high)
            return;

        int pivotIndex = ChoosePivotIndexForStrategy(low, high, pivotStrategy);
        pivotIndex = PartitionIndex(array, low, high, pivotIndex);
        Sort(array, low, pivotIndex - 1, pivotStrategy);
        Sort(array, pivotIndex + 1, high, pivotStrategy);
    }

    private static int PartitionIndex<T>(T[] array, int low, int high, int pivotIndex)
        where T : IComparable
    {
        T pivot = array[pivotIndex];
        Swap(array, pivotIndex, high);
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j].CompareTo(pivot) < 0)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);
        return i + 1;
    }

    private static void Swap<T>(T[] array, int i, int j)
    {
        T temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    private static int ChoosePivotIndexForStrategy(int low, int high, PivotStrategy pivotStrategy)
    {
        switch (pivotStrategy)
        {
            case PivotStrategy.Middle:
                return low + (high - low) / 2;
            case PivotStrategy.Random:
                return random.Next(low, high + 1);
            default:
                return high;
        }
    }
}

public enum PivotStrategy
{
    High,
    Middle,
    Random,
}