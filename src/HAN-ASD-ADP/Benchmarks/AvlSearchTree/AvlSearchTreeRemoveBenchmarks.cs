using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.AvlSearchTree;

public class AvlSearchTreeRemoveBenchmarks : SetupAvlSearchTreeBenchmarks
{
    [Params(1, 5, 10)]
    public override int Times { get; set; }

    [Benchmark]
    public void Remove()
    {
        for (int i = 0; i < Times; i++)
        {
            filledTree.Remove(i * 2);
        }
    }
}