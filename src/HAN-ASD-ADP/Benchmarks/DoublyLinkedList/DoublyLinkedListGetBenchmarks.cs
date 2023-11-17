using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DoublyLinkedList;

public class DoublyLinkedListGetBenchmarks : SetupDoublyLinkedListBenchmarks
{
    [Benchmark]
    public void Get_First() => list.Get(Size);

    [Benchmark]
    public void Get_Mid() => list.Get(Size / 2);

    [Benchmark]
    public void Get_Last() => list.Get(Size - 1);
}