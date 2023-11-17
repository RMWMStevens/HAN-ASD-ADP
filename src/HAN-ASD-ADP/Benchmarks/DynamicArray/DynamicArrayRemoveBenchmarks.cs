using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayRemoveBenchmarks : SetupDynamicArrayBenchmarks
{
    [Benchmark]
    public void Remove_Min() => array.Remove(0);

    [Benchmark]
    public void Remove_Mid() => array.Remove(Size / 2);

    [Benchmark]
    public void Remove_Max() => array.Remove(Size - 1);
}