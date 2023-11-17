
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WBRHZI : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method    | Size    | Mean          | Error        | StdDev        | Median       | Allocated |
---------- |-------- |--------------:|-------------:|--------------:|-------------:|----------:|
 **Get_First** | **1**       |            **NA** |           **NA** |            **NA** |           **NA** |        **NA** |
 Get_Mid   | 1       |      71.43 ns |    24.612 ns |     71.796 ns |     100.0 ns |     544 B |
 Get_Last  | 1       |      62.24 ns |    23.357 ns |     68.135 ns |     100.0 ns |     544 B |
 **Get_First** | **10**      |            **NA** |           **NA** |            **NA** |           **NA** |        **NA** |
 Get_Mid   | 10      |     111.00 ns |    31.201 ns |     91.998 ns |     100.0 ns |     544 B |
 Get_Last  | 10      |      65.22 ns |    21.947 ns |     61.902 ns |     100.0 ns |     544 B |
 **Get_First** | **100**     |            **NA** |           **NA** |            **NA** |           **NA** |        **NA** |
 Get_Mid   | 100     |      96.05 ns |     7.701 ns |     19.601 ns |     100.0 ns |     544 B |
 Get_Last  | 100     |      67.01 ns |    20.944 ns |     60.762 ns |     100.0 ns |     544 B |
 **Get_First** | **1000**    |            **NA** |           **NA** |            **NA** |           **NA** |        **NA** |
 Get_Mid   | 1000    |     500.00 ns |     0.000 ns |      0.000 ns |     500.0 ns |     544 B |
 Get_Last  | 1000    |      72.94 ns |    16.530 ns |     44.690 ns |     100.0 ns |     544 B |
 **Get_First** | **10000**   |            **NA** |           **NA** |            **NA** |           **NA** |        **NA** |
 Get_Mid   | 10000   |   4,385.00 ns |    85.801 ns |     98.809 ns |   4,400.0 ns |     544 B |
 Get_Last  | 10000   |     120.20 ns |    24.345 ns |     71.400 ns |     100.0 ns |     544 B |
 **Get_First** | **100000**  |            **NA** |           **NA** |            **NA** |           **NA** |        **NA** |
 Get_Mid   | 100000  |  42,276.47 ns |   692.454 ns |    711.099 ns |  42,200.0 ns |     544 B |
 Get_Last  | 100000  |     244.79 ns |    29.267 ns |     84.442 ns |     200.0 ns |     544 B |
 **Get_First** | **1000000** |            **NA** |           **NA** |            **NA** |           **NA** |        **NA** |
 Get_Mid   | 1000000 | 430,770.83 ns | 7,305.217 ns | 14,419.785 ns | 427,800.0 ns |     496 B |
 Get_Last  | 1000000 |     418.28 ns |   131.171 ns |    372.111 ns |     300.0 ns |     496 B |

Benchmarks with issues:
  DoublyLinkedListGetBenchmarks.Get_First: Job-WBRHZI(InvocationCount=1, UnrollFactor=1) [Size=1]
  DoublyLinkedListGetBenchmarks.Get_First: Job-WBRHZI(InvocationCount=1, UnrollFactor=1) [Size=10]
  DoublyLinkedListGetBenchmarks.Get_First: Job-WBRHZI(InvocationCount=1, UnrollFactor=1) [Size=100]
  DoublyLinkedListGetBenchmarks.Get_First: Job-WBRHZI(InvocationCount=1, UnrollFactor=1) [Size=1000]
  DoublyLinkedListGetBenchmarks.Get_First: Job-WBRHZI(InvocationCount=1, UnrollFactor=1) [Size=10000]
  DoublyLinkedListGetBenchmarks.Get_First: Job-WBRHZI(InvocationCount=1, UnrollFactor=1) [Size=100000]
  DoublyLinkedListGetBenchmarks.Get_First: Job-WBRHZI(InvocationCount=1, UnrollFactor=1) [Size=1000000]
