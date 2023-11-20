
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-ZZBLTY : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method       | Length | Times | Mean         | Error       | StdDev      | Median       | Allocated |
------------- |------- |------ |-------------:|------------:|------------:|-------------:|----------:|
 **DequeueLeft**  | **10000**  | **1**     |     **243.0 ns** |    **18.20 ns** |    **53.66 ns** |     **200.0 ns** |     **544 B** |
 DequeueRight | 10000  | 1     |     166.0 ns |    21.94 ns |    64.70 ns |     150.0 ns |     544 B |
 **DequeueLeft**  | **10000**  | **100**   |   **1,791.6 ns** |    **50.74 ns** |   **135.43 ns** |   **1,800.0 ns** |     **544 B** |
 DequeueRight | 10000  | 100   |   1,483.3 ns |    67.97 ns |   196.10 ns |   1,400.0 ns |     544 B |
 **DequeueLeft**  | **10000**  | **10000** | **136,083.3 ns** | **2,176.98 ns** | **1,699.64 ns** | **135,800.0 ns** |     **544 B** |
 DequeueRight | 10000  | 10000 | 104,300.0 ns | 1,562.93 ns | 1,305.12 ns | 104,600.0 ns |     544 B |
