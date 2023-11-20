using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.PriorityQueue;

public class PriorityQueueAddBenchmarks : SetupPriorityQueueBenchmarks
{
    [Benchmark]
    public void Add()
    {
        for (int i = 0; i < Times; i++)
        {
            queue.Add(Length);
        }
    }
}