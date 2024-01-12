using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.Graph;

public class GraphShortestPathBenchmarks : SetupGraphBenchmarks
{
    [Benchmark]
    public void Find_0_1() => graph.FindShortestPathUnweighted("0", "1");

    [Benchmark]
    public void Find_0_2() => graph.FindShortestPathUnweighted("0", "2");

    [Benchmark]
    public void Find_0_3() => graph.FindShortestPathUnweighted("0", "3");

    [Benchmark]
    public void Find_0_4() => graph.FindShortestPathUnweighted("0", "4");

    [Benchmark]
    public void Find_0_5() => graph.FindShortestPathUnweighted("0", "5");

    [Benchmark]
    public void Find_0_6() => graph.FindShortestPathUnweighted("0", "6");
}