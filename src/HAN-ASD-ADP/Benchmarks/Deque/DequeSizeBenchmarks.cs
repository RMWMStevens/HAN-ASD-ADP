using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.Deque;

public class DequeSizeBenchmarks : SetupDequeBenchmarks
{
    [Params(1)]
    public override int Times { get; set; }

    [Benchmark]
    public void Size() => deque.Size();
}