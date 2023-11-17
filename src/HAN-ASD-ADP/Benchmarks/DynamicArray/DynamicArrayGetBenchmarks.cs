using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayGetBenchmarks
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
    public void Get_First() => array.Get(ArraySize);

    [Benchmark]
    public void Get_Mid() => array.Get(ArraySize / 2);

    [Benchmark]
    public void Get_Last() => array.Get(ArraySize - 1);
}