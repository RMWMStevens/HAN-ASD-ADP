using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

[MemoryDiagnoser]
public class SetupDynamicArrayBenchmarks : BenchmarkSetup
{
    protected DynamicArray<int> array;

    [Params(1, 10, 100, 1000, 10000, 100000, 1000000)]
    public int Size { get; set; }

    public SetupDynamicArrayBenchmarks()
        : base(nameof(SetupDynamicArrayBenchmarks))
    { }

    [IterationSetup]
    public void Setup()
    {
        array = new();
        for (int i = 0; i < Size; i++)
        {
            array.Add(i);
        }
    }
}