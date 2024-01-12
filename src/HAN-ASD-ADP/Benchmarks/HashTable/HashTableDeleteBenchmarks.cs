using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.HashTable;

public class HashTableDeleteBenchmarks : SetupHashTableBenchmarks
{
    [Params(1, 5, 10)]
    public override int Times { get; set; }

    [Benchmark]
    public void Delete_SeparateChaining()
    {
        for (int i = 0; i < Times; i++)
        {
            hashTableChaining.Delete(i.ToString());
        }
    }

    [Benchmark]
    public void Delete_LinearProbing()
    {
        for (int i = 0; i < Times; i++)
        {
            hashTableChaining.Delete(i.ToString());
        }
    }

    [Benchmark]
    public void Delete_QuadraticProbing()
    {
        for (int i = 0; i < Times; i++)
        {
            hashTableChaining.Delete(i.ToString());
        }
    }
}