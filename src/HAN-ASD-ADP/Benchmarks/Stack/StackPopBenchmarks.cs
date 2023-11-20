using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.Stack;

public class StackPopBenchmarks : SetupStackBenchmarks
{
    [Benchmark]
    public void Pop()
    {
        for (int i = 0; i < Times; i++)
        {
            stack.Pop();
        }
    }
}