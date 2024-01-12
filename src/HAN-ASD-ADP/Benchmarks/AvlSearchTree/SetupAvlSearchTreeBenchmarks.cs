using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.AvlSearchTree;

public class SetupAvlSearchTreeBenchmarks : BenchmarkSetup
{
    protected AvlSearchTree<int> emptyTree;
    protected AvlSearchTree<int> filledTree;

    [Params(100, 10000)]
    public virtual int Length { get; set; }

    [Params(1)]
    public virtual int Times { get; set; }

    public SetupAvlSearchTreeBenchmarks()
    : base(nameof(SetupAvlSearchTreeBenchmarks))
    { }

    [IterationSetup]
    public void Setup()
    {
        emptyTree = new AvlSearchTree<int>();
        filledTree = new AvlSearchTree<int>();

        for (int i = 0; i < Length; i++)
        {
            filledTree.Insert(i * 2); // No uneven numbers for Insert test purposes
        }
    }
}