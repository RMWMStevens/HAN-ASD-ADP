using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.AvlSearchTree;

public class AvlSearchTreeInsertBenchmarks : SetupAvlSearchTreeBenchmarks
{
    [Params(10000)]
    public override int Length { get; set; }

    [Benchmark]
    public void Insert_EmptyTree_SlideValuesMin2()
    {
        emptyTree.Insert(2);
        emptyTree.Insert(4);
        emptyTree.Insert(6);
        emptyTree.Insert(8);
        emptyTree.Insert(12);
        emptyTree.Insert(14);
    }

    [Benchmark]
    public void Insert_EmptyTree_SlideValuesMin1()
    {
        emptyTree.Insert(2);
        emptyTree.Insert(4);
        emptyTree.Insert(6);
        emptyTree.Insert(8);
        emptyTree.Insert(12);
        emptyTree.Insert(14);
        emptyTree.Insert(16);
    }

    [Benchmark]
    public void Insert_EmptyTree_SlideValues()
    {
        emptyTree.Insert(2);
        emptyTree.Insert(4);
        emptyTree.Insert(6);
        emptyTree.Insert(8);
        emptyTree.Insert(12);
        emptyTree.Insert(14);
        emptyTree.Insert(16);
        emptyTree.Insert(18);
    }

    [Benchmark]
    public void Insert_49_FilledTree()
    {
        emptyTree.Insert(49);
    }

    [Benchmark]
    public void Insert_513_FilledTree()
    {
        emptyTree.Insert(513);
    }

    [Benchmark]
    public void Insert_6549_FilledTree()
    {
        emptyTree.Insert(6549);
    }

    [Benchmark]
    public void Insert_9413_FilledTree()
    {
        emptyTree.Insert(9413);
    }
}