using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.PriorityQueue;

public class PriorityQueueFindMinBenchmarks : SetupPriorityQueueBenchmarks
{
    [Benchmark]
    public void FindMin()
    {
        for (int i = 0; i < Times; i++)
        {
            queue.FindMin();
        }
    }
}