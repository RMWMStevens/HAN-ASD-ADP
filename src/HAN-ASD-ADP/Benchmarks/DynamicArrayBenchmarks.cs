using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Datasets;
using HAN_ASD_ADP.Implementations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HAN_ASD_ADP.Benchmarks;

public class DynamicArrayBenchmarks
{
    protected DatasetSorteren dataset;

    [GlobalSetup]
    public virtual async Task GlobalSetup()
    {
        dataset = await DatasetCache<DatasetSorteren>.GetAsync();
    }

    public static List<Type> Get() => new List<Type>
    {
        typeof(DynamicArrayAddBenchmarks),
        typeof(DynamicArrayRemoveBenchmarks),
        typeof(DynamicArrayRemoveAtBenchmarks),
    };
}

public class DynamicArrayAddBenchmarks : DynamicArrayBenchmarks
{
    const int Number = 1000;

    private DynamicArray<int> oplopend2;
    private DynamicArray<float> float8001;
    private DynamicArray<double> gesorteerdAflopend3;
    private DynamicArray<int?> leeg0;
    private DynamicArray<int?> null3;
    private DynamicArray<object> onsorteerbaar3;
    private DynamicArray<int> willekeurig10000;

    [IterationSetup]
    public void IterationSetup()
    {
        oplopend2 = new();
        foreach (var value in dataset.LijstOplopend2)
        {
            oplopend2.Add(value);
        }
        
        float8001 = new();
        foreach (var value in dataset.LijstFloat8001)
        {
            float8001.Add(value);
        }

        gesorteerdAflopend3 = new();
        foreach (var value in dataset.LijstGesorteerdAflopend3)
        {
            gesorteerdAflopend3.Add(value);
        }

        leeg0 = new();
        foreach (var value in dataset.LijstLeeg0)
        {
            leeg0.Add(value);
        }

        null3 = new();
        foreach (var value in dataset.LijstNull3)
        {
            null3.Add(value);
        }

        onsorteerbaar3 = new();
        foreach (var value in dataset.LijstOnsorteerbaar3)
        {
            onsorteerbaar3.Add(value);
        }

        willekeurig10000 = new();
        foreach (var value in dataset.LijstWillekeurig10000)
        {
            willekeurig10000.Add(value);
        }
    }

    [Benchmark]
    public void Add_Oplopend2_1x() => oplopend2.Add(Number);

    [Benchmark]
    public void Add_Oplopend2_2x()
    {
        oplopend2.Add(Number);
        oplopend2.Add(Number);
    }

    [Benchmark]
    public void Add_Oplopend2_3x()
    {
        oplopend2.Add(Number);
        oplopend2.Add(Number);
        oplopend2.Add(Number);
    }

    [Benchmark]
    public void Add_Oplopend2_4x()
    {
        oplopend2.Add(Number);
        oplopend2.Add(Number);
        oplopend2.Add(Number);
        oplopend2.Add(Number);
    }

    [Benchmark]
    public void Add_Float8001() => float8001.Add(Number);

    [Benchmark]
    public void Add_GesorteerdAflopend3() => gesorteerdAflopend3.Add(Number);

    [Benchmark]
    public void Add_Leeg0_1x() => leeg0.Add(Number);

    [Benchmark]
    public void Add_Leeg0_2x()
    {
        leeg0.Add(Number);
        leeg0.Add(Number);
    }

    [Benchmark]
    public void Add_Leeg0_3x()
    {
        leeg0.Add(Number);
        leeg0.Add(Number);
        leeg0.Add(Number);
    }

    [Benchmark]
    public void Add_Leeg0_4x()
    {
        leeg0.Add(Number);
        leeg0.Add(Number);
        leeg0.Add(Number);
        leeg0.Add(Number);
    }

    [Benchmark]
    public void Add_Leeg0_5x()
    {
        leeg0.Add(Number);
        leeg0.Add(Number);
        leeg0.Add(Number);
        leeg0.Add(Number);
        leeg0.Add(Number);
    }

    [Benchmark]
    public void Add_Leeg0_6x()
    {
        leeg0.Add(Number);
        leeg0.Add(Number);
        leeg0.Add(Number);
        leeg0.Add(Number);
        leeg0.Add(Number);
        leeg0.Add(Number);
    }

    [Benchmark(Baseline = true)]
    public void Add_Null3_1x() => null3.Add(Number);

    [Benchmark]
    public void Add_Null3_2x()
    {
        null3.Add(Number);
        null3.Add(Number);
    }

    [Benchmark]
    public void Add_Onsorteerbaar3() => onsorteerbaar3.Add(Number);

    [Benchmark]
    public void Add_Willekeurig10000() => willekeurig10000.Add(Number);
}

public class DynamicArrayRemoveBenchmarks : DynamicArrayBenchmarks
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

public class DynamicArrayRemoveAtBenchmarks : DynamicArrayBenchmarks
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