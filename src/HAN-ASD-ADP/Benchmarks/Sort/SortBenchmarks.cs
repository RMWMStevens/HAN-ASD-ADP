using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.Sort;

public class SortBenchmarks : SetupSortBenchmarks
{
    [Benchmark]
    public void Ascending()
    {
        Algorithm.Sort(ascendingArray);
    }

    [Benchmark]
    public void Descending()
    {
        Algorithm.Sort(descendingArray);
    }

    [Benchmark]
    public void Random()
    {
        Algorithm.Sort(randomArray);
    }

    [Benchmark]
    public void SameValue()
    {
        Algorithm.Sort(sameValueArray);
    }
}