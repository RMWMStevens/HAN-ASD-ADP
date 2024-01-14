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
            hashTableChaining.Add($"Test_{i}", i);
        }
    }

    [Benchmark]
    public void Add_LinearProbing()
    {
        for (int i = 0; i < Times; i++)
        {
            hashTableLinearProbing.Add($"Test_{i}", i);
        }
    }

    [Benchmark]
    public void Add_QuadraticProbing()
    {
        for (int i = 0; i < Times; i++)
        {
            hashTableQuadraticProbing.Add($"Test_{i}", i);
        }
    }
}