using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayCountBenchmarks : SetupDynamicArrayBenchmarks
{
    [Benchmark]
    public int Count() => array.Count;
}