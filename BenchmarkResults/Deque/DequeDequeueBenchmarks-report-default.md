
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-FJSBUM : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method       | Length | Times | Mean         | Error       | StdDev       | Median       | Allocated |
------------- |------- |------ |-------------:|------------:|-------------:|-------------:|----------:|
 **DequeueLeft**  | **10000**  | **1**     |     **229.0 ns** |    **20.62 ns** |     **60.79 ns** |     **200.0 ns** |     **544 B** |
 DequeueRight | 10000  | 1     |     171.7 ns |    22.87 ns |     67.07 ns |     200.0 ns |     544 B |
 **DequeueLeft**  | **10000**  | **100**   |   **1,641.5 ns** |    **48.67 ns** |    **138.86 ns** |   **1,650.0 ns** |     **544 B** |
 DequeueRight | 10000  | 100   |   1,447.9 ns |    55.83 ns |    159.29 ns |   1,450.0 ns |     544 B |
 **DequeueLeft**  | **10000**  | **10000** | **150,367.4 ns** | **4,242.86 ns** | **12,173.57 ns** | **150,900.0 ns** |     **544 B** |
 DequeueRight | 10000  | 10000 | 114,241.3 ns | 3,088.07 ns |  8,709.97 ns | 112,350.0 ns |     256 B |
