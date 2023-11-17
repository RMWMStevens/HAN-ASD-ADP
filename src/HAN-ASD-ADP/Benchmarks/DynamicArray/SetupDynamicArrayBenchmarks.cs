using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

[MemoryDiagnoser]
public class SetupDynamicArrayBenchmarks : BenchmarkSetup
{
    protected DynamicArray<int> array;

    [Params(100, 10000, 1000000)]
    public virtual int Length { get; set; }

    [Params(1)]
    public virtual int Times { get; set; }

    public SetupDynamicArrayBenchmarks()
        : base(nameof(SetupDynamicArrayBenchmarks))
    { }

    [IterationSetup]
    public void Setup()
    {
        array = new();
        for (int i = 0; i < Length; i++)
        {
            array.Add(i);
        }
    }
}