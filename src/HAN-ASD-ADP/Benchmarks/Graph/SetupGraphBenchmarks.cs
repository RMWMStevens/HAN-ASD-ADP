using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Datasets;
using System.Threading.Tasks;

namespace HAN_ASD_ADP.Benchmarks.Graph;

[MemoryDiagnoser]
public class SetupGraphBenchmarks : BenchmarkSetup
{
    protected Implementations.Graph emptyGraph;
    protected Implementations.Graph graph;
    protected Implementations.Graph graphWeighted;

    protected DatasetGrafen dataset;

    public SetupGraphBenchmarks()
        : base(nameof(SetupGraphBenchmarks))
    { }

    [IterationSetup]
    public void Setup()
    {
        emptyGraph = new();
        graph = new();
        graphWeighted = new();

        dataset = DatasetCache<DatasetGrafen>.GetAsync().GetAwaiter().GetResult();
        graph.LoadLijnlijst(dataset.Lijnlijst);
        graphWeighted.LoadLijnlijstGewogen(dataset.LijnlijstGewogen);
    }
}