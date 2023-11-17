using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayRemoveAtBenchmarks
{
    private DynamicArray<int> array;

    [Params(10, 100, 1000, 10000)]
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
    public void RemoveAt_First() => array.RemoveAt(0);

    [Benchmark]
    public void RemoveAt_Mid() => array.RemoveAt(ArraySize / 2);

    [Benchmark]
    public void RemoveAt_Last() => array.RemoveAt(ArraySize - 1);
}