using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.Stack;

public class StackIsEmptyBenchmarks : SetupStackBenchmarks
{
    [Params(1)]
    public override int Times { get; set; }

    [Benchmark]
    public void IsEmpty()
    {
        for (int i = 0; i < Times; i++)
        {
            stack.IsEmpty();
        }
    }
}