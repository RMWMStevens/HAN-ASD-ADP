using static HAN_ASD_ADP.Benchmarks.Sort.SetupSortBenchmarks;

namespace HAN_ASD_ADP.Benchmarks.Sort;

public class SortAlgorithm
{
    public SortDelegate Sort { get; }

    public string Name { get; }

    public SortAlgorithm(string name, SortDelegate sort)
    {
        Name = name;
        Sort = sort;
    }

    public override string ToString() => Name;
}