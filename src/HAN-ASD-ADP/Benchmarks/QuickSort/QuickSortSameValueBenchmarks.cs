using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.QuickSort;

public class QuickSortSameValueBenchmarks : SetupQuickSortBenchmarks
{
    [Params(10, 100, 1000, 10000)]
    public override int Length { get; set; }

    [Benchmark]
    public void SameValue() => Algorithm.Sort(sameValueArray);
}
