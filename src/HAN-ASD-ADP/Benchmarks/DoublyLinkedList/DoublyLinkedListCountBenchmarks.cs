using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DoublyLinkedList;

public class DoublyLinkedListCountBenchmarks : SetupDoublyLinkedListBenchmarks
{
    [Benchmark]
    public int Count() => list.Count;
}