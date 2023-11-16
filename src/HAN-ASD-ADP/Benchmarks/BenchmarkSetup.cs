using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Datasets;
using System;
using System.Threading.Tasks;

public abstract class BenchmarkSetup<T> : IBenchmarkSetup
    where T : IDataset
{
    protected T dataset;

    [GlobalSetup]
    public virtual async Task GlobalSetup()
    {
        dataset = await DatasetCache<T>.GetAsync();
    }

    public abstract Type[] GetBenchmarks();
}