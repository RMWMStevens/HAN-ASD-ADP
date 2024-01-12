using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.AvlSearchTree;

public class AvlSearchTreeFindMinBenchmarks : SetupAvlSearchTreeBenchmarks
{
    [Benchmark]
    public void FindMin()
    {
        filledTree.FindMin();
    }
}