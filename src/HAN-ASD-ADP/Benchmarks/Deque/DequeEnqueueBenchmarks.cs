using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.Deque;

public class DequeEnqueueBenchmarks : SetupDequeBenchmarks
{
    [Benchmark]
    public void EnqueueLeft_Empty()
    {
        for (int i = 0; i < Times; i++)
        {
            emptyDeque.EnqueueLeft(i);
        }
    }

    [Benchmark]
    public void EnqueueRight_Empty()
    {
        for (int i = 0; i < Times; i++)
        {
            emptyDeque.EnqueueRight(i);
        }
    }

    [Benchmark]
    public void EnqueueLeft_Prefilled()
    {
        for (int i = 0; i < Times; i++)
        {
            prefilledDeque.EnqueueLeft(i);
        }
    }

    [Benchmark]
    public void EnqueueRight_Prefilled()
    {
        for (int i = 0; i < Times; i++)
        {
            prefilledDeque.EnqueueRight(i);
        }
    }
}