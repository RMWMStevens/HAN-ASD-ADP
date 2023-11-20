using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DoublyLinkedList;

public class DoublyLinkedListAddBenchmarks : SetupDoublyLinkedListBenchmarks
{
    [Params(100, 10000, 1000000)]
    public override int Length { get; set; }

    [Params(1, 5, 10)]
    public override int Times { get; set; }

    [Benchmark]
    public void Add()
    {
        for (int i = 0; i < Times; i++)
        {
            list.Add(i);
        }
    }
}