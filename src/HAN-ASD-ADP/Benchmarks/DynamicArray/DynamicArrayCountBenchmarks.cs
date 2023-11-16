using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;
using System.Threading.Tasks;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayCountBenchmarks : SetupDynamicArrayBenchmarks
{
    private DynamicArray<int> aflopend2;
    private DynamicArray<float> float8001;
    private DynamicArray<int> willekeurig10000;

    public override async Task GlobalSetup()
    {
        await base.GlobalSetup();

        aflopend2 = new();
        foreach (var value in dataset.LijstAflopend2)
        {
            aflopend2.Add(value);
        }

        float8001 = new();
        foreach (var value in dataset.LijstFloat8001)
        {
            float8001.Add(value);
        }

        willekeurig10000 = new();
        foreach (var value in dataset.LijstWillekeurig10000)
        {
            willekeurig10000.Add(value);
        }
    }

    [Benchmark(Baseline = true)]
    public int Count_Aflopend2() => aflopend2.Count;

    [Benchmark]
    public int Count_Float8001() => float8001.Count;

    [Benchmark]
    public int Count_Willekeurig10000() => willekeurig10000.Count;
}