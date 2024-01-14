using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.HashTable;

[MemoryDiagnoser]
public class SetupHashTableBenchmarks : BenchmarkSetup
{
    protected HashTableChaining<string, int> hashTableChaining;
    protected HashTableProbing<string, int> hashTableLinearProbing;
    protected HashTableProbing<string, int> hashTableQuadraticProbing;

    public int Length { get; set; } = 199;

    [Params(1)]
    public virtual int Times { get; set; }

    public SetupHashTableBenchmarks()
        : base(nameof(SetupHashTableBenchmarks))
    { }

    [IterationSetup]
    public void Setup()
    {
        hashTableChaining = new(size: Length);
        hashTableLinearProbing = new(linearProbing: true, tableSize: Length);
        hashTableQuadraticProbing = new(linearProbing: false, tableSize: Length);

        for (int i = 0; i < Length / 3; i++)
        {
            hashTableChaining.Add(i.ToString(), i);
        }

        for (int i = 0; i < Length / 3; i++)
        {
            hashTableLinearProbing.Add(i.ToString(), i);
        }

        for (int i = 0; i < Length / 3; i++)
        {
            hashTableQuadraticProbing.Add(i.ToString(), i);
        }
    }
}