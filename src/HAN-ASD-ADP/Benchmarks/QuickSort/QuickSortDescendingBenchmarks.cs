using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.QuickSort;

public class QuickSortDescendingBenchmarks : SetupQuickSortBenchmarks
{
    [Benchmark]
    public void Descending() => Algorithm.Sort(descendingArray);
}