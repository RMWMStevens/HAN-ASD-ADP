using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DoublyLinkedList;

public class DoublyLinkedListRemoveAtBenchmarks : SetupDoublyLinkedListBenchmarks
{
    [Benchmark]
    public void RemoveAt_First() => list.RemoveAt(0);

    [Benchmark]
    public void RemoveAt_Mid() => list.RemoveAt(Size / 2);

    [Benchmark]
    public void RemoveAt_Last() => list.RemoveAt(Size - 1);
}