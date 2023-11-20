using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.Deque;

public class DequeDequeueBenchmarks : SetupDequeBenchmarks
{
    [Params(10000)]
    public override int Length { get; set; }

    [Benchmark]
    public void DequeueLeft()
    {
        for (int i = 0; i < Times; i++)
        {
            deque.DequeueLeft();
        }
    }

    [Benchmark]
    public void DequeueRight()
    {
        for (int i = 0; i < Times; i++)
        {
            deque.DequeueRight();
        }
    }
}