using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.DoublyLinkedList;

[MemoryDiagnoser]
public class SetupDoublyLinkedListBenchmarks : BenchmarkSetup
{
    protected DoublyLinkedList<int> list;

    [Params(100, 10000, 1000000)]
    public virtual int Length { get; set; }

    [Params(1)]
    public virtual int Times { get; set; }

    public SetupDoublyLinkedListBenchmarks()
        : base(nameof(SetupDoublyLinkedListBenchmarks))
    { }

    [IterationSetup]
    public void Setup()
    {
        list = new();
        for (int i = 0; i < Length; i++)
        {
            list.Add(i);
        }
    }
}