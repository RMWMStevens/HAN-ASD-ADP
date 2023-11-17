using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayRemoveBenchmarks
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
    public void Remove_Min() => array.Remove(0);

    [Benchmark]
    public void Remove_Mid() => array.Remove(ArraySize / 2);

    [Benchmark]
    public void Remove_Max() => array.Remove(ArraySize - 1);
}