using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.DoublyLinkedList;

[MemoryDiagnoser]
public class SetupDoublyLinkedListBenchmarks : BenchmarkSetup
{
    protected DoublyLinkedList<int> list;

    [Params(1, 10, 100, 1000, 10000, 100000, 1000000)]
    public int Size { get; set; }

    public SetupDoublyLinkedListBenchmarks()
        : base(nameof(SetupDoublyLinkedListBenchmarks))
    { }

    [IterationSetup]
    public void Setup()
    {
        list = new();
        for (int i = 0; i < Size; i++)
        {
            list.Add(i);
        }
    }
}