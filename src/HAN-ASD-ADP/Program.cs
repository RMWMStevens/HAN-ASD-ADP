using BenchmarkDotNet.Running;
using HAN_ASD_ADP.Benchmarks;
using HAN_ASD_ADP.Benchmarks.BinarySearch;
using HAN_ASD_ADP.Benchmarks.Deque;
using HAN_ASD_ADP.Benchmarks.DoublyLinkedList;
using HAN_ASD_ADP.Benchmarks.DynamicArray;
using HAN_ASD_ADP.Benchmarks.MergeSort;
using HAN_ASD_ADP.Benchmarks.PriorityQueue;
using HAN_ASD_ADP.Benchmarks.QuickSort;
using HAN_ASD_ADP.Benchmarks.Sort;
using HAN_ASD_ADP.Benchmarks.Stack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

var config = new BenchmarkConfig();
var benchmarks = new List<IBenchmarkSetup>
{
    //new SetupDynamicArrayBenchmarks(),
    //new SetupDoublyLinkedListBenchmarks(),
    //new SetupStackBenchmarks(),
    //new SetupDequeBenchmarks(),
    //new SetupPriorityQueueBenchmarks(),
    //new SetupBinarySearchBenchmarks(),
    //new SetupSortBenchmarks(),
    //new SetupMergeSortBenchmarks(),
    new SetupQuickSortBenchmarks(),
}.SelectMany(_ => _.GetBenchmarks());

Console.WriteLine("Starting benchmarks.");

BenchmarkRunner.Run(benchmarks.ToArray(), config);

Console.WriteLine("Copying benchmark results.");
var targetPath = BenchmarkResultSaver.Copy(new(Directory.GetCurrentDirectory()));
Console.WriteLine($"Copied results to '{targetPath}'.");
Console.WriteLine("Benchmarks are done running. Press any key to close the window.");
Console.ReadKey();