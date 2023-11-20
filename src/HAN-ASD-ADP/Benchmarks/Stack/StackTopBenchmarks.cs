using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.Stack;

public class StackTopBenchmarks : SetupStackBenchmarks
{
    [Benchmark]
    public void Top()
    {
        for (int i = 0; i < Times; i++)
        {
            stack.Top();
        }
    }
}