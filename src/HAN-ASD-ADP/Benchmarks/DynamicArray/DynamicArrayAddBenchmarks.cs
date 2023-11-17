using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayAddBenchmarks
{
    private DynamicArray<int> array;

    [Params(3, 4, 5, 31, 32, 33, 100, 1000, 10000)]
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
    public void Add() => array.Add(ArraySize);
}