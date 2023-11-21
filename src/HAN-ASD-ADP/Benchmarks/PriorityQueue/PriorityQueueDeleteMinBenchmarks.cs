using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.PriorityQueue;

public class PriorityQueueDeleteMinBenchmarks : SetupPriorityQueueBenchmarks
{
    [Params(10000)]
    public override int Length { get; set; }

    [Benchmark]
    public void DeleteMin()
    {
        for (int i = 0; i < Times; i++)
        {
            queue.DeleteMin();
        }
    }
}