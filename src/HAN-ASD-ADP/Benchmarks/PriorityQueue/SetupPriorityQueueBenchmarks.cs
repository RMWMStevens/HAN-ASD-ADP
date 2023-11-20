using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;
using System;

namespace HAN_ASD_ADP.Benchmarks.PriorityQueue;

[MemoryDiagnoser]
public class SetupPriorityQueueBenchmarks : BenchmarkSetup
{
    protected PriorityQueue<int> queue;

    [Params(100, 10000)]
    public virtual int Length { get; set; }

    [Params(1, 100, 10000)]
    public virtual int Times { get; set; }

    public SetupPriorityQueueBenchmarks()
        : base(nameof(SetupPriorityQueueBenchmarks))
    { }

    [IterationSetup]
    public void Setup()
    {
        queue = new();
        var random = new Random();
        for (int i = 0; i < Length; i++)
        {
            queue.Add(random.Next(1, Length));
        }
    }
}