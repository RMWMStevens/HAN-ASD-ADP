using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayRemoveAtBenchmarks : SetupDynamicArrayBenchmarks
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
    public void RemoveAt_Aflopend2_1() => RemoveAt(aflopend2, 1);

    [Benchmark]
    public void RemoveAt_Aflopend2_1_Again() => RemoveAt(aflopend2, 1);

    [Benchmark]
    public void RemoveAt_Float8001_0() => RemoveAt(float8001, 0);

    [Benchmark]
    public void RemoveAt_Float8001_4000() => RemoveAt(float8001, 4000);

    [Benchmark]
    public void RemoveAt_Float8001_8000() => RemoveAt(float8001, 8000);

    [Benchmark]
    public void RemoveAt_Willekeurig10000_0() => RemoveAt(willekeurig10000, 0);

    [Benchmark]
    public void RemoveAt_Willekeurig10000_2000() => RemoveAt(willekeurig10000, 2000);

    [Benchmark]
    public void RemoveAt_Willekeurig10000_4000() => RemoveAt(willekeurig10000, 4000);

    [Benchmark]
    public void RemoveAt_Willekeurig10000_6000() => RemoveAt(willekeurig10000, 6000);

    [Benchmark]
    public void RemoveAt_Willekeurig10000_8000() => RemoveAt(willekeurig10000, 8000);

    private void RemoveAt<T>(DynamicArray<T> aflopend2, int position) => aflopend2.RemoveAt(position);
}