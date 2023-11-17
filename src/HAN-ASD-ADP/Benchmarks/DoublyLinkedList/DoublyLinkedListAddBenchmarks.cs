using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DoublyLinkedList;

public class DoublyLinkedListAddBenchmarks : SetupDoublyLinkedListBenchmarks
{
    [Params(3, 4, 5, 31, 32, 33, 100, 1000, 10000, 100000, 1000000)]
    public new int Size { get; set; }

    [Benchmark]
    public void Add() => list.Add(Size);
}