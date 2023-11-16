using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Implementations;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class DynamicArrayAddBenchmarks : SetupDynamicArrayBenchmarks
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
        if (dataset.LijstOplopend2.Count != oplopend2.Count)
        {
            oplopend2 = new();
            foreach (var value in dataset.LijstOplopend2)
            {
                oplopend2.Add(value);
            }
        };
        
        if (dataset.LijstFloat8001.Count != float8001.Count)
        {
            float8001 = new();
            foreach (var value in dataset.LijstFloat8001)
            {
                float8001.Add(value);
            }
        }

        if (dataset.LijstGesorteerdAflopend3.Count != gesorteerdAflopend3.Count)
        {
            gesorteerdAflopend3 = new();
            foreach (var value in dataset.LijstGesorteerdAflopend3)
            {
                gesorteerdAflopend3.Add(value);
            }
        }

        if (dataset.LijstLeeg0.Count != leeg0.Count)
        {
            leeg0 = new();
            foreach (var value in dataset.LijstLeeg0)
            {
                leeg0.Add(value);
            }
        }

        if (dataset.LijstNull3.Count != null3.Count)
        {
            null3 = new();
            foreach (var value in dataset.LijstNull3)
            {
                null3.Add(value);
            }
        }
        
        if (dataset.LijstOnsorteerbaar3.Count != onsorteerbaar3.Count)
        {
            onsorteerbaar3 = new();
            foreach (var value in dataset.LijstOnsorteerbaar3)
            {
                onsorteerbaar3.Add(value);
            }
        }

        if (dataset.LijstWillekeurig10000.Count != willekeurig10000.Count)
        {
            willekeurig10000 = new();
            foreach (var value in dataset.LijstWillekeurig10000)
            {
                willekeurig10000.Add(value);
            }
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