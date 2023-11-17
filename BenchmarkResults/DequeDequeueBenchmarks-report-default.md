
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WSLHHA : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method       | Length | Times | Mean       | Error    | StdDev    | Median     | Allocated |
------------- |------- |------ |-----------:|---------:|----------:|-----------:|----------:|
 **DequeueLeft**  | **101**    | **1**     |   **143.4 ns** | **20.18 ns** |  **59.18 ns** |   **100.0 ns** |     **544 B** |
 DequeueRight | 101    | 1     |   125.0 ns | 27.43 ns |  80.87 ns |   100.0 ns |     544 B |
 **DequeueLeft**  | **101**    | **100**   | **1,664.4 ns** | **61.02 ns** | **167.04 ns** | **1,600.0 ns** |     **544 B** |
 DequeueRight | 101    | 100   | 1,496.8 ns | 52.09 ns | 147.77 ns | 1,500.0 ns |     544 B |
 **DequeueLeft**  | **1001**   | **1**     |   **174.0 ns** | **23.92 ns** |  **70.52 ns** |   **200.0 ns** |     **544 B** |
 DequeueRight | 1001   | 1     |   163.6 ns | 22.03 ns |  64.61 ns |   200.0 ns |     544 B |
 **DequeueLeft**  | **1001**   | **100**   | **1,611.5 ns** | **34.19 ns** |  **88.25 ns** | **1,600.0 ns** |     **544 B** |
 DequeueRight | 1001   | 100   | 1,475.0 ns | 44.70 ns | 128.96 ns | 1,500.0 ns |     544 B |
