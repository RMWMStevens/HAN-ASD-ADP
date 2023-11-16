using BenchmarkDotNet.Attributes;
using HAN_ASD_ADP.Datasets;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HAN_ASD_ADP.Benchmarks;

public class DoublyLinkedListBenchmarks
{
    protected DatasetSorteren dataset;

    [GlobalSetup]
    public virtual async Task GlobalSetup()
    {
        dataset = await DatasetCache<DatasetSorteren>.GetAsync();
    }

    public static List<Type> Get() => new()
    {
        typeof(DoublyLinkedListAddBenchmarks),
    };
}

public class DoublyLinkedListAddBenchmarks : DoublyLinkedListBenchmarks { }