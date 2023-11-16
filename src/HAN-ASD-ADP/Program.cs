using BenchmarkDotNet.Running;
using HAN_ASD_ADP.Benchmarks;
using HAN_ASD_ADP.Benchmarks.DoublyLinkedList;
using HAN_ASD_ADP.Benchmarks.DynamicArray;
using System;
using System.Collections.Generic;
using System.IO;

var config = new BenchmarkConfig();
var setups = new List<IBenchmarkSetup>
{
    new SetupDynamicArrayBenchmarks(),
    new SetupDoublyLinkedListBenchmarks(),
};

Console.WriteLine("Starting benchmarks.");

foreach (var setup in setups)
{
    Console.WriteLine($"Running {setup} benchmarks");
    var types = setup.GetBenchmarks();
    BenchmarkRunner.Run(types, config);
}

Console.WriteLine("Copying benchmark results.");
BenchmarkResultSaver.Copy(new(Directory.GetCurrentDirectory()));
Console.WriteLine("Benchmarks are done running. Press any key to close the window.");
Console.ReadKey();