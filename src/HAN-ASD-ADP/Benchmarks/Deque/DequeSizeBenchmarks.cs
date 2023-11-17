using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.Deque;

public class DequeSizeBenchmarks : SetupDequeBenchmarks
{
    [Benchmark]
    public void Size() => prefilledDeque.Size();
}