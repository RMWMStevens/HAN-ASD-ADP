using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayRemoveBenchmarks : SetupDynamicArrayBenchmarks
{
    [Params(1, 5, 10)]
    public override int Times { get; set; }

    [Benchmark]
    public void Remove_Min()
    {
        for (int i = 0; i < Times; i++)
        {
            array.Remove(i);
        }
    }

    [Benchmark]
    public void Remove_Mid()
    {
        for (int i = 0; i < Times; i++)
        {
            array.Remove(Length / 2 + i);
        }
    }

    [Benchmark]
    public void Remove_Max()
    {
        for (int i = 0; i < Times; i++)
        {
            array.Remove(array.Count - 1);
        }
    }
}