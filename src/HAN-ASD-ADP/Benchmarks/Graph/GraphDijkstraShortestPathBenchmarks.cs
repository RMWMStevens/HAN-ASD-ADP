using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.Graph;

public class GraphDijkstraShortestPathBenchmarks : SetupGraphBenchmarks
{
    [Benchmark]
    public void Find_0_1() => graphWeighted.FindShortestPathDijkstra("0", "1");

    [Benchmark]
    public void Find_0_2() => graphWeighted.FindShortestPathDijkstra("0", "2");

    [Benchmark]
    public void Find_0_3() => graphWeighted.FindShortestPathDijkstra("0", "3");

    [Benchmark]
    public void Find_0_4() => graphWeighted.FindShortestPathDijkstra("0", "4");
}