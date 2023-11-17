using System;

namespace HAN_ASD_ADP.Benchmarks.DoublyLinkedList;

public class SetupDoublyLinkedListBenchmarks : IBenchmarkSetup
{
    public Type[] GetBenchmarks() => new[]
    {
        typeof(DoublyLinkedListAddBenchmarks),
    };
}