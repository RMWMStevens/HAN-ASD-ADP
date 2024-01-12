using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.HashTable;

public class HashTableAddBenchmarks : SetupHashTableBenchmarks
{
    [Params(1, 5, 10)]
    public override int Times { get; set; }

    [Benchmark]
    public void Add_SeparateChaining()
    {
        for (int i = 0; i < Times; i++)
        {
            hashTableChaining.Add((i * 100).ToString(), i);
        }
    }

    [Benchmark]
    public void Add_LinearProbing()
    {
        for (int i = 0; i < Times; i++)
        {
            hashTableLinearProbing.Add(i.ToString(), i);
        }
    }

    [Benchmark]
    public void Add_QuadraticProbing()
    {
        for (int i = 0; i < Times; i++)
        {
            hashTableQuadraticProbing.Add(i.ToString(), i);
        }
    }
}