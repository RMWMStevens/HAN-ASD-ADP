using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayAddBenchmarks : SetupDynamicArrayBenchmarks
{
    [Params(3, 4, 5, 31, 32, 33, 100, 1000, 10000, 100000, 1000000)]
    public override int Size { get; set; }

    [Benchmark]
    public void Add() => array.Add(Size);

    [Benchmark]
    public void Add_alwaysExpandBy1() => array.Add(Size, false);
}