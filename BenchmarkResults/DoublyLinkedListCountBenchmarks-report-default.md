
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-HRDTVF : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Size    | Mean        | Error      | StdDev      | Median      | Allocated |
------- |-------- |------------:|-----------:|------------:|------------:|----------:|
 **Count**  | **100**     |   **0.0000 ns** |  **0.0000 ns** |   **0.0000 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **10000**   |  **54.0000 ns** | **20.6889 ns** |  **61.0017 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **1000000** | **196.7742 ns** | **73.0327 ns** | **207.1817 ns** | **100.0000 ns** |     **496 B** |
