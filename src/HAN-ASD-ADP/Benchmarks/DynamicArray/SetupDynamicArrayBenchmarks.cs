using HAN_ASD_ADP.Datasets;
using System;

namespace HAN_ASD_ADP.Benchmarks.DynamicArray;

public class SetupDynamicArrayBenchmarks : BenchmarkSetup<DatasetSorteren>
{
    public override Type[] GetBenchmarks() => new[]
    {
        typeof(DynamicArrayAddBenchmarks),
        typeof(DynamicArrayCountBenchmarks),
        typeof(DynamicArrayGetBenchmarks),
        typeof(DynamicArrayRemoveBenchmarks),
        typeof(DynamicArrayRemoveAtBenchmarks),
    };
}