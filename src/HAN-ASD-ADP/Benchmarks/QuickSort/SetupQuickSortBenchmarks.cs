using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Benchmarks.Sort;
using System;
using System.Collections.Generic;

namespace HAN_ASD_ADP.Benchmarks.QuickSort;

[MemoryDiagnoser]
public class SetupQuickSortBenchmarks : BenchmarkSetup
{
    protected int[] ascendingArray;
    protected int[] descendingArray;
    protected int[] randomArray;
    protected int[] sameValueArray;

    [Params(10, 100, 1000, 10000, 100000)]
    public virtual int Length { get; set; }

    [ParamsSource(nameof(Algorithms))]
    public SortAlgorithm Algorithm { get; set; }

    public delegate void SortDelegate(int[] array);

    public static IEnumerable<SortAlgorithm> Algorithms => new SortAlgorithm[]
    {
        new("Quick (High)", Implementations.QuickSort.SortHigh),
        new("Quick (Middle)", Implementations.QuickSort.SortMiddle),
        new("Quick (Median)", Implementations.QuickSort.SortMedian),
        new("Quick (Random)", Implementations.QuickSort.SortRandom),
    };

    public SetupQuickSortBenchmarks()
        : base(nameof(SetupQuickSortBenchmarks))
    { }

    [IterationSetup]
    public void Setup()
    {
        SetupAscendingArray();
        SetupDescendingArray();
        SetupRandomArray();
        SetupSameValueArray();
    }

    private void SetupAscendingArray()
    {
        ascendingArray = new int[Length];
        for (int i = 0; i < Length; i++)
        {
            ascendingArray[i] = i;
        }
    }

    private void SetupDescendingArray()
    {
        descendingArray = new int[Length];
        for (int i = Length; i > 0; i--)
        {
            descendingArray[i - 1] = i;
        }
    }

    private void SetupRandomArray()
    {
        randomArray = new int[Length];
        var random = new Random();
        for (int i = 0; i < Length; i++)
        {
            randomArray[i] = random.Next(0, Length);
        }
    }

    private void SetupSameValueArray()
    {
        sameValueArray = new int[Length];
        for (int i = 0; i < Length; i++)
        {
            sameValueArray[i] = 1;
        }
    }
}
