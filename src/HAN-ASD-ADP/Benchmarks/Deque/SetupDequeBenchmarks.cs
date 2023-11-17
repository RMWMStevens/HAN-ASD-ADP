using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.Deque;

[MemoryDiagnoser]
public class SetupDequeBenchmarks : BenchmarkSetup
{
    protected Deque<int> deque;

    [Params(0, 100, 10000)]
    public virtual int Length { get; set; }

    [Params(100, 100, 10000)]
    public virtual int Times { get; set; }

    public SetupDequeBenchmarks()
        : base(nameof(SetupDequeBenchmarks))
    { }

    [IterationSetup]
    public void Setup()
    {
        deque = new();
        for (int i = 0; i < Length; i++)
        {
            deque.EnqueueLeft(i);
        }
    }
}