using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.QuickSort;

public class QuickSortAscendingBenchmarks : SetupQuickSortBenchmarks
{
    [Benchmark]
    public void Ascending() => Algorithm.Sort(ascendingArray);
}