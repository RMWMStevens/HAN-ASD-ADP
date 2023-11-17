using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.Deque;

public class DequeIsEmptyBenchmarks : SetupDequeBenchmarks
{
    [Benchmark]
    public void IsEmpty() => prefilledDeque.IsEmpty();
}