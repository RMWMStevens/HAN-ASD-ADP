using BenchmarkDotNet.Running;
using HAN_ASD_ADP.Benchmarks;
using HAN_ASD_ADP.Benchmarks.Deque;
using HAN_ASD_ADP.Benchmarks.DoublyLinkedList;
using HAN_ASD_ADP.Benchmarks.DynamicArray;
using HAN_ASD_ADP.Benchmarks.Stack;
using System;
using System.Collections.Generic;
using System.IO;

var config = new BenchmarkConfig();
var setups = new List<IBenchmarkSetup>
{
    //new SetupDynamicArrayBenchmarks(),
    //new SetupDoublyLinkedListBenchmarks(),
    //new SetupStackBenchmarks(),
    new SetupDequeBenchmarks(),
};

Console.WriteLine("Starting benchmarks.");

foreach (var setup in setups)
{
    var types = setup.GetBenchmarks();
    BenchmarkRunner.Run(types, config);
}

Console.WriteLine("Copying benchmark results.");
var targetPath = BenchmarkResultSaver.Copy(new(Directory.GetCurrentDirectory()));
Console.WriteLine($"Copied results to '{targetPath}'.");
Console.WriteLine("Benchmarks are done running. Press any key to close the window.");
Console.ReadKey();