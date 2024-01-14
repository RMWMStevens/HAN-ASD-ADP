using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.AvlSearchTree;

public class AvlSearchTreeFindMaxBenchmarks : SetupAvlSearchTreeBenchmarks
{
    [Benchmark]
    public void FindMax()
    {
        filledTree.FindMax();
    }
}