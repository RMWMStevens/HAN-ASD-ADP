using BenchmarkDotNet.Attributes;
using System;
using System.Linq;
using System.Reflection;

namespace HAN_ASD_ADP.Benchmarks;

public class BenchmarkSetup : IBenchmarkSetup
{
    public string Name { get; set; }

    public BenchmarkSetup(string name) => Name = StripToFolderName(name);

    public Type[] GetBenchmarks()
    {
        var benchmarkAssembly = Assembly.GetExecutingAssembly();
        var benchmarkTypes = benchmarkAssembly.GetTypes()
            .Where(t => t.Namespace == $"{typeof(BenchmarkSetup).Namespace}.{Name}")
            .Where(t => t.GetMethods().Any(m => m.GetCustomAttributes(typeof(BenchmarkAttribute), false).Any()));
        return benchmarkTypes.ToArray();
    }

    private string StripToFolderName(string name)
    {
        name = name.Replace("Setup", string.Empty);
        name = name.Replace("Benchmarks", string.Empty);
        return name;
    }
}