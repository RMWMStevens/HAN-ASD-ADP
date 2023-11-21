using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayAddBenchmarks : SetupDynamicArrayBenchmarks
{
    [Params(3, 65535, 1000000)]
    public override int Length { get; set; }

    [Params(1, 5, 10)]
    public override int Times { get; set; }

    [Benchmark]
    public void Add()
    {
        for (int i = 0; i < Times; i++)
        {
            array.Add(Length);
        }
    }

    [Benchmark]
    public void Add_AlwaysResize()
    {
        for (int i = 0; i < Times; i++)
        {
            array.Add(Length, false);
        }
    }
}