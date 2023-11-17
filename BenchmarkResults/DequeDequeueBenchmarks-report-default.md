
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-BIRKPB : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method       | Length | Times   | Mean     | Error     | StdDev    | Allocated |
------------- |------- |-------- |---------:|----------:|----------:|----------:|
 **DequeueLeft**  | **0**      | **100**     |       **NA** |        **NA** |        **NA** |        **NA** |
 DequeueRight | 0      | 100     |       NA |        NA |        NA |        NA |
 **DequeueLeft**  | **0**      | **10000**   |       **NA** |        **NA** |        **NA** |        **NA** |
 DequeueRight | 0      | 10000   |       NA |        NA |        NA |        NA |
 **DequeueLeft**  | **0**      | **1000000** |       **NA** |        **NA** |        **NA** |        **NA** |
 DequeueRight | 0      | 1000000 |       NA |        NA |        NA |        NA |
 **DequeueLeft**  | **1000**   | **100**     | **1.595 μs** | **0.0447 μs** | **0.1185 μs** |     **544 B** |
 DequeueRight | 1000   | 100     | 1.442 μs | 0.0579 μs | 0.1660 μs |     544 B |
 **DequeueLeft**  | **1000**   | **10000**   |       **NA** |        **NA** |        **NA** |        **NA** |
 DequeueRight | 1000   | 10000   |       NA |        NA |        NA |        NA |
 **DequeueLeft**  | **1000**   | **1000000** |       **NA** |        **NA** |        **NA** |        **NA** |
 DequeueRight | 1000   | 1000000 |       NA |        NA |        NA |        NA |

Benchmarks with issues:
  DequeDequeueBenchmarks.DequeueLeft: Job-BIRKPB(InvocationCount=1, UnrollFactor=1) [Length=0, Times=100]
  DequeDequeueBenchmarks.DequeueRight: Job-BIRKPB(InvocationCount=1, UnrollFactor=1) [Length=0, Times=100]
  DequeDequeueBenchmarks.DequeueLeft: Job-BIRKPB(InvocationCount=1, UnrollFactor=1) [Length=0, Times=10000]
  DequeDequeueBenchmarks.DequeueRight: Job-BIRKPB(InvocationCount=1, UnrollFactor=1) [Length=0, Times=10000]
  DequeDequeueBenchmarks.DequeueLeft: Job-BIRKPB(InvocationCount=1, UnrollFactor=1) [Length=0, Times=1000000]
  DequeDequeueBenchmarks.DequeueRight: Job-BIRKPB(InvocationCount=1, UnrollFactor=1) [Length=0, Times=1000000]
  DequeDequeueBenchmarks.DequeueLeft: Job-BIRKPB(InvocationCount=1, UnrollFactor=1) [Length=1000, Times=10000]
  DequeDequeueBenchmarks.DequeueRight: Job-BIRKPB(InvocationCount=1, UnrollFactor=1) [Length=1000, Times=10000]
  DequeDequeueBenchmarks.DequeueLeft: Job-BIRKPB(InvocationCount=1, UnrollFactor=1) [Length=1000, Times=1000000]
  DequeDequeueBenchmarks.DequeueRight: Job-BIRKPB(InvocationCount=1, UnrollFactor=1) [Length=1000, Times=1000000]
