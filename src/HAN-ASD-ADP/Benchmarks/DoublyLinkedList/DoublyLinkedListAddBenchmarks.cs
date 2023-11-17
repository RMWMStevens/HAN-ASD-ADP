using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DoublyLinkedList;

public class DoublyLinkedListAddBenchmarks : SetupDoublyLinkedListBenchmarks
{
    [Params(3, 4, 5, 65535, 65536, 65537, 1000000)]
    public override int Size { get; set; }

    [Benchmark]
    public void Add() => list.Add(Size);
}