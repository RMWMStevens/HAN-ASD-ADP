using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DoublyLinkedList;

public class DoublyLinkedListRemoveBenchmarks : SetupDoublyLinkedListBenchmarks
{
    [Benchmark]
    public void Remove_Min() => list.Remove(0);

    [Benchmark]
    public void Remove_Mid() => list.Remove(Size / 2);

    [Benchmark]
    public void Remove_Max() => list.Remove(Size - 1);
}