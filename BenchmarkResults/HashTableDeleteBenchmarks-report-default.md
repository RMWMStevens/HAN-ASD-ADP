
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WZUDHU : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                  | Times | Length | Mean     | Error    | StdDev    | Median   | Allocated |
------------------------ |------ |------- |---------:|---------:|----------:|---------:|----------:|
 **Delete_SeparateChaining** | **1**     | **11**     | **441.2 ns** | **46.61 ns** | **135.21 ns** | **400.0 ns** |     **544 B** |
 Delete_LinearProbing    | 1     | 11     | 370.5 ns | 17.78 ns |  45.89 ns | 400.0 ns |     544 B |
 Delete_QuadraticProbing | 1     | 11     | 444.9 ns | 53.95 ns | 157.38 ns | 400.0 ns |     544 B |
 **Delete_SeparateChaining** | **5**     | **11**     | **713.1 ns** | **56.73 ns** | **166.38 ns** | **600.0 ns** |     **544 B** |
 Delete_LinearProbing    | 5     | 11     | 721.2 ns | 67.37 ns | 197.57 ns | 600.0 ns |     544 B |
 Delete_QuadraticProbing | 5     | 11     | 602.2 ns | 47.59 ns | 134.23 ns | 600.0 ns |     544 B |
 **Delete_SeparateChaining** | **10**    | **11**     |       **NA** |       **NA** |        **NA** |       **NA** |        **NA** |
 Delete_LinearProbing    | 10    | 11     |       NA |       NA |        NA |       NA |        NA |
 Delete_QuadraticProbing | 10    | 11     |       NA |       NA |        NA |       NA |        NA |

Benchmarks with issues:
  HashTableDeleteBenchmarks.Delete_SeparateChaining: Job-WZUDHU(InvocationCount=1, UnrollFactor=1) [Times=10, Length=11]
  HashTableDeleteBenchmarks.Delete_LinearProbing: Job-WZUDHU(InvocationCount=1, UnrollFactor=1) [Times=10, Length=11]
  HashTableDeleteBenchmarks.Delete_QuadraticProbing: Job-WZUDHU(InvocationCount=1, UnrollFactor=1) [Times=10, Length=11]
