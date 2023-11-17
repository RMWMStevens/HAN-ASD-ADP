using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.Stack;

[MemoryDiagnoser]
public class SetupStackBenchmarks : BenchmarkSetup
{
    protected Stack<int> stack;

    [Params(100, 10000, 1000000)]
    public virtual int Size { get; set; }

    [Params(1)]
    public virtual int Times { get; set; }

    public SetupStackBenchmarks()
        : base(nameof(SetupStackBenchmarks))
    { }

    [IterationSetup]
    public void Setup()
    {
        stack = new();
    }
}