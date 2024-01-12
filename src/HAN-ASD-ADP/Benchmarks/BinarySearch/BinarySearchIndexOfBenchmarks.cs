using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.BinarySearch;

public class BinarySearchIndexOfBenchmarks : SetupBinarySearchBenchmarks
{
    [Benchmark]
    public void Get_First_IndexOfLinearSearch() => binarySearch.IndexOfLinearSearch(0);

    [Benchmark]
    public void Get_Mid_IndexOfLinearSearch() => binarySearch.IndexOfLinearSearch(Length / 2);

    [Benchmark]
    public void Get_Last_IndexOfLinearSearch() => binarySearch.IndexOfLinearSearch(Length - 1);

    [Benchmark]
    public void Get_First_IndexOfBinarySearchRecursive() => binarySearch.IndexOfBinarySearchRecursive(0);

    [Benchmark]
    public void Get_Mid_IndexOfBinarySearchRecursive() => binarySearch.IndexOfBinarySearchRecursive(Length / 2);

    [Benchmark]
    public void Get_Last_IndexOfBinarySearchRecursive() => binarySearch.IndexOfBinarySearchRecursive(Length - 1);
}