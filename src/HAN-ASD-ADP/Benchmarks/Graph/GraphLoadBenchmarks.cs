using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.Graph;

public class GraphLoadBenchmarks : SetupGraphBenchmarks
{
    [Benchmark]
    public void LoadLijnlijst() => emptyGraph.LoadLijnlijst(dataset.Lijnlijst);

    [Benchmark]
    public void LoadVerbindingslijst() => emptyGraph.LoadVerbindingslijst(dataset.Verbindingslijst);

    [Benchmark]
    public void LoadVerbindingsmatrix() => emptyGraph.LoadVerbindingsmatrix(dataset.Verbindingsmatrix);

    [Benchmark]
    public void LoadLijnlijstGewogen() => emptyGraph.LoadLijnlijstGewogen(dataset.LijnlijstGewogen);

    [Benchmark]
    public void LoadVerbindingslijstGewogen() => emptyGraph.LoadVerbindingslijstGewogen(dataset.VerbindingslijstGewogen);

    [Benchmark]
    public void LoadVerbindingsmatrixGewogen() => emptyGraph.LoadVerbindingsmatrixGewogen(dataset.VerbindingsmatrixGewogen);
}
