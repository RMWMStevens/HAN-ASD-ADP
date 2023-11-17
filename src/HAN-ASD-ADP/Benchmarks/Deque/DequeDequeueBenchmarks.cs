using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.Deque;

public class DequeDequeueBenchmarks : SetupDequeBenchmarks
{
    [Benchmark]
    public void DequeueLeft()
    {
        for (int i = 0; i < Times; i++)
        {
            prefilledDeque.DequeueLeft();
        }
    }

    [Benchmark]
    public void DequeueRight()
    {
        for (int i = 0; i < Times; i++)
        {
            prefilledDeque.DequeueRight();
        }
    }

    [Benchmark]
    public void DequeueLeft_Prefilled()
    {
        for (int i = 0; i < Times; i++)
        {
            prefilledDeque.DequeueLeft();
        }
    }

    [Benchmark]
    public void DequeueRight_Prefilled()
    {
        for (int i = 0; i < Times; i++)
        {
            prefilledDeque.DequeueRight();
        }
    }
}