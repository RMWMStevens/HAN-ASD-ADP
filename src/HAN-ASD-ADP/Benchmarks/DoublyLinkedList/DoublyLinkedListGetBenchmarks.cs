﻿using BenchmarkDotNet.Attributes;

namespace HAN_ASD_ADP.Benchmarks.DoublyLinkedList;

public class DoublyLinkedListGetBenchmarks : SetupDoublyLinkedListBenchmarks
{
    [Benchmark]
    public void Get_First() => list.Get(0);

    [Benchmark]
    public void Get_25perc() => list.Get(Length / 4);

    [Benchmark]
    public void Get_Half() => list.Get(Length / 2);

    [Benchmark]
    public void Get_75perc() => list.Get(Length / 4 * 3);

    [Benchmark]
    public void Get_Last() => list.Get(Length - 1);

    [Benchmark]
    public void Get_First_NoTail() => list.Get(0, false);

    [Benchmark]
    public void Get_25perc_NoTail() => list.Get(Length / 4, false);

    [Benchmark]
    public void Get_Half_NoTail() => list.Get(Length / 2, false);

    [Benchmark]
    public void Get_75perc_NoTail() => list.Get(Length / 4 * 3, false);

    [Benchmark]
    public void Get_Last_NoTail() => list.Get(Length - 1, false);
}