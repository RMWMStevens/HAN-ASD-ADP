using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DoublyLinkedList;

public class DoublyLinkedListRemoveBenchmarks : SetupDoublyLinkedListBenchmarks
{
    [Params(1, 5, 10)]
    public override int Times { get; set; }

    [Benchmark]
    public void Remove_Min()
    {
        for (int i = 0; i < Times; i++)
        {
            list.Remove(i);
        }
    }

    [Benchmark]
    public void Remove_Mid()
    {
        for (int i = 0; i < Times; i++)
        {
            list.Remove(list.Count / 2);
        }
    }

    [Benchmark]
    public void Remove_Max()
    {
        for (int i = 0; i < Times; i++)
        {
            list.Remove(list.Count - 1);
        }
    }
}