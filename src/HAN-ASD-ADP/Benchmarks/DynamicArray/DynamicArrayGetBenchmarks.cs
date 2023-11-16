using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;
using System.Threading.Tasks;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayGetBenchmarks : SetupDynamicArrayBenchmarks
{
    private DynamicArray<int> gesorteerdOplopend3;
    private DynamicArray<float> float8001;
    private DynamicArray<int> oplopend10000;

    public override async Task GlobalSetup()
    {
        await base.GlobalSetup();

        if (dataset.LijstGesorteerdAflopend3.Count != gesorteerdOplopend3.Count)
        {
            gesorteerdOplopend3 = new();
            foreach (var value in dataset.LijstGesorteerdOplopend3)
            {
                gesorteerdOplopend3.Add(value);
            }
        }

        if (dataset.LijstFloat8001.Count != float8001.Count)
        {
            float8001 = new();
            foreach (var value in dataset.LijstFloat8001)
            {
                float8001.Add(value);
            }
        }

        if (dataset.LijstOplopend10000.Count != oplopend10000.Count)
        {
            oplopend10000 = new();
            foreach (var value in dataset.LijstOplopend10000)
            {
                oplopend10000.Add(value);
            }
        }
    }

    [Benchmark(Baseline = true)]
    public void Get_GesorteerdOplopend3_0() => gesorteerdOplopend3.Get(0);

    [Benchmark]
    public void Get_GesorteerdOplopend3_1() => gesorteerdOplopend3.Get(1);

    [Benchmark]
    public void Get_GesorteerdOplopend3_2() => gesorteerdOplopend3.Get(2);

    [Benchmark]
    public void Get_Float8001_0() => float8001.Get(0);

    [Benchmark]
    public void Get_Float8001_1() => float8001.Get(1);

    [Benchmark]
    public void Get_Float8001_2() => float8001.Get(2);

    [Benchmark]
    public void Get_Float8001_4000() => float8001.Get(4000);

    [Benchmark]
    public void Get_Float8001_8000() => float8001.Get(8000);

    [Benchmark]
    public void Get_Oplopend10000_0() => oplopend10000.Get(0);

    [Benchmark]
    public void Get_Oplopend10000_1() => oplopend10000.Get(1);

    [Benchmark]
    public void Get_Oplopend10000_2() => oplopend10000.Get(2);

    [Benchmark]
    public void Get_Oplopend10000_4000() => oplopend10000.Get(4000);

    [Benchmark]
    public void Get_Oplopend10000_8000() => oplopend10000.Get(8000);
}