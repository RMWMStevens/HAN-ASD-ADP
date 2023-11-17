using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.Deque;

public class DequeDequeueBenchmarks : SetupDequeBenchmarks
{
    [Params(101, 1001)]
    public override int Length { get; set; }

    [Params(1, 100)]
    public override int Times { get; set; }

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