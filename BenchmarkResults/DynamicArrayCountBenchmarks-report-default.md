
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-HRDTVF : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Size    | Mean        | Error      | StdDev     | Median      | Allocated |
------- |-------- |------------:|-----------:|-----------:|------------:|----------:|
 **Count**  | **100**     |   **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **10000**   |  **28.0000 ns** | **15.3046 ns** | **45.1261 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **1000000** | **128.5714 ns** | **24.1152 ns** | **70.3452 ns** | **100.0000 ns** |     **544 B** |
