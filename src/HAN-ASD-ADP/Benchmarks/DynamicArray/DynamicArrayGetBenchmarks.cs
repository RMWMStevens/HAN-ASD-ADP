using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayGetBenchmarks : SetupDynamicArrayBenchmarks
{
    [Benchmark]
    public void Get_First() => array.Get(0);

    [Benchmark]
    public void Get_Mid() => array.Get(Size / 2);

    [Benchmark]
    public void Get_Last() => array.Get(Size - 1);
}