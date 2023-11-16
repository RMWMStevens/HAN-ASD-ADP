using BenchmarkDotNet.Attributes;
using System;
using System.Threading.Tasks;

public interface IBenchmarkSetup
{
    [GlobalSetup]
    public Task GlobalSetup();

    public abstract Type[] GetBenchmarks();
}