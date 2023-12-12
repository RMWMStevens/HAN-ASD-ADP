using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;
using System.Collections.Generic;

namespace HAN_ASD_ADP.Benchmarks.BinarySearch;

public class SetupBinarySearchBenchmarks : BenchmarkSetup
{
    protected BinarySearch<int> binarySearch;

    [Params(100, 10000)]
    public virtual int Length { get; set; }

    [Params(1, 10, 100)]
    public virtual int Times { get; set; }

    public SetupBinarySearchBenchmarks()
    : base(nameof(SetupBinarySearchBenchmarks))
    { }

    [IterationSetup]
    public void Setup()
    {
        List<int> intList = new List<int>();
        for (int i = 0; i < Length; i++)
        {
            intList.Add(i);
        }
        binarySearch = new BinarySearch<int>(intList);
    }
}