using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.QuickSort;

public class QuickSortRandomBenchmarks : SetupQuickSortBenchmarks
{
    [Benchmark]
    public void Random() => Algorithm.Sort(randomArray);
}
