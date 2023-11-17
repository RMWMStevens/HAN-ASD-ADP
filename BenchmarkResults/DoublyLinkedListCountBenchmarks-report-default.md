
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-GFXNRG : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Size    | Mean        | Error      | StdDev      | Median      | Allocated |
------- |-------- |------------:|-----------:|------------:|------------:|----------:|
 **Count**  | **10**      |   **0.0000 ns** |  **0.0000 ns** |   **0.0000 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **100**     |  **41.0000 ns** | **18.0978 ns** |  **53.3617 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **1000**    |  **61.6162 ns** | **18.6801 ns** |  **54.7854 ns** | **100.0000 ns** |     **544 B** |
 **Count**  | **10000**   |  **73.1183 ns** | **15.7129 ns** |  **44.5748 ns** | **100.0000 ns** |     **544 B** |
 **Count**  | **100000**  | **158.7629 ns** | **25.2473 ns** |  **73.2470 ns** | **100.0000 ns** |     **544 B** |
 **Count**  | **1000000** | **172.1649 ns** | **61.2855 ns** | **177.8004 ns** | **100.0000 ns** |     **496 B** |
