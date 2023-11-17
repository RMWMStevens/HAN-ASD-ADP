using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.Deque;

[MemoryDiagnoser]
public class SetupDequeBenchmarks : BenchmarkSetup
{
    protected Deque<int> emptyDeque;
    protected Deque<int> prefilledDeque;

    [Params(1, 100, 10000, 1000000)]
    public virtual int Times { get; set; }

    public SetupDequeBenchmarks()
        : base(nameof(SetupDequeBenchmarks))
    { }

    [IterationSetup]
    public void Setup()
    {
        emptyDeque = new();
        prefilledDeque = new();
        for (int i = 0; i < Times; i++)
        {
            prefilledDeque.EnqueueLeft(i);
        }
    }
}