using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.Deque;

public class DequeEnqueueBenchmarks : SetupDequeBenchmarks
{
    [Benchmark]
    public void EnqueueLeft()
    {
        for (int i = 0; i < Times; i++)
        {
            deque.EnqueueLeft(i);
        }
    }

    [Benchmark]
    public void EnqueueRight()
    {
        for (int i = 0; i < Times; i++)
        {
            deque.EnqueueRight(i);
        }
    }
}