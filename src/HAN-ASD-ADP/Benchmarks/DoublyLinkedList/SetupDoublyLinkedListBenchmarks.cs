using HAN_ASD_ADP.Datasets;
using System;

namespace HAN_ASD_ADP.Benchmarks.DoublyLinkedList;

public class SetupDoublyLinkedListBenchmarks : BenchmarkSetup<DatasetSorteren>
{
    public override Type[] GetBenchmarks() => new[]
    {
        typeof(DoublyLinkedListAddBenchmarks),
    };
}