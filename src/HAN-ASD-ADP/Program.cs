using BenchmarkDotNet.Running;
using HAN_ASD_ADP.Benchmarks;
using HAN_ASD_ADP.Benchmarks.Config;
using System;
using System.Collections.Generic;
using System.Linq;

var config = new BenchmarkConfig();
var benchmarks = new List<List<Type>>()
{
    DynamicArrayBenchmarks.Get(),
    DoublyLinkedListBenchmarks.Get(),

}.SelectMany(_ => _);

Console.WriteLine("Starting benchmarks...");

foreach (var type in benchmarks)
{
    Console.WriteLine($"Running {type.Name}");
    BenchmarkRunner.Run(type, config);
}

Console.WriteLine("Benchmarks are done running. Press any key to close the window.");
Console.ReadKey();