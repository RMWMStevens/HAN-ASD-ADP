using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayRemoveBenchmarks : SetupDynamicArrayBenchmarks
{
    private DynamicArray<int> aflopend2;
    private DynamicArray<float> float8001;
    private DynamicArray<int> willekeurig10000;

    [IterationSetup]
    public void IterationSetup()
    {
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
    public void Remove_Aflopend2_1() => Remove(aflopend2, 1);

    [Benchmark]
    public void Remove_Aflopend2_N10033224() => Remove(aflopend2, -10033224);

    [Benchmark]
    public void Remove_Float8001_11312312312312_324() => Remove(float8001, 11312312312312.324f);

    [Benchmark]
    public void Remove_Float8001_1() => Remove(float8001, 1);

    [Benchmark]
    public void Remove_Willekeurig10000_5824() => Remove(willekeurig10000, 5824);

    [Benchmark]
    public void Remove_Willekeurig10000_8541() => Remove(willekeurig10000, 8541);

    [Benchmark]
    public void Remove_Willekeurig10000_8009() => Remove(willekeurig10000, 8009);

    private void Remove<T>(DynamicArray<T> aflopend2, T value) => aflopend2.Remove(value);
}