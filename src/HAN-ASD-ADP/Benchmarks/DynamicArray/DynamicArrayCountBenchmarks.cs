using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayCountBenchmarks
{
    private DynamicArray<int> array;

    [Params(1, 10, 100, 1000, 10000)]
    public int ArraySize;

    [IterationSetup]
    public void Setup()
    {
        array = new();
        for (int i = 0; i < ArraySize; i++)
        {
            array.Add(i);
        }
    }

    [Benchmark]
    public int Count() => array.Count;
}