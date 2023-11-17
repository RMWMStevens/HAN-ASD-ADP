using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayRemoveAtBenchmarks : SetupDynamicArrayBenchmarks
{
    [Benchmark]
    public void RemoveAt_First() => array.RemoveAt(0);

    [Benchmark]
    public void RemoveAt_Mid() => array.RemoveAt(Size / 2);

    [Benchmark]
    public void RemoveAt_Last() => array.RemoveAt(Size - 1);
}