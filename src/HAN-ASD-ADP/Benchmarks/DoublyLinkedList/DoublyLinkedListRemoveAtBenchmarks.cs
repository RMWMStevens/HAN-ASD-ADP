using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DoublyLinkedList;

public class DoublyLinkedListRemoveAtBenchmarks : SetupDoublyLinkedListBenchmarks
{
    [Params(1, 5, 10)]
    public override int Times { get; set; }

    [Benchmark]
    public void RemoveAt_First()
    {
        for (int i = 0; i < Times; i++)
        {
            list.RemoveAt(0);
        }
    }

    [Benchmark]
    public void RemoveAt_Mid()
    {
        for (int i = 0; i < Times; i++)
        {
            list.RemoveAt(list.Count / 2);
        }
    }

    [Benchmark]
    public void RemoveAt_Last()
    {
        list.RemoveAt(list.Count - 1);
    }
}