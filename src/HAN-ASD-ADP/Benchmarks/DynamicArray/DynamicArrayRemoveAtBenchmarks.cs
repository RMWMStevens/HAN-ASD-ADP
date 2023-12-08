using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayRemoveAtBenchmarks : SetupDynamicArrayBenchmarks
{
    [Params(5, 50, 5000)]
    public override int Times { get; set; }

    [Benchmark]
    public void RemoveAt_First()
    {
        for (int i = 0; i < Times; i++)
        {
            array.RemoveAt(0);
        }
    }

    [Benchmark]
    public void RemoveAt_Mid()
    {
        for (int i = 0; i < Times; i++)
        {
            array.RemoveAt(array.Count / 2);
        }
    }

    [Benchmark]
    public void RemoveAt_Last()
    {
        array.RemoveAt(array.Count - 1);
    }

    [Benchmark]
    public void RemoveAt_AlwaysResizeFirst()
    {
        for (int i = 0; i < Times; i++)
        {
            array.RemoveAt(0, false);
        }
    }

    [Benchmark]
    public void RemoveAt_AlwaysResizeMid()
    {
        for (int i = 0; i < Times; i++)
        {
            array.RemoveAt(array.Count / 2, false);
        }
    }

    [Benchmark]
    public void RemoveAt_AlwaysResizeLast()
    {
        array.RemoveAt(array.Count - 1, false);
    }
}