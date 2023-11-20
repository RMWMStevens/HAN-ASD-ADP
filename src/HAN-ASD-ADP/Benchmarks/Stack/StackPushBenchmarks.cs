using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.Stack;

public class StackPushBenchmarks : SetupStackBenchmarks
{
    [Benchmark]
    public void Push()
    {
        for (int i = 0; i < Times; i++)
        {
            stack.Push(i);
        }
    }
}