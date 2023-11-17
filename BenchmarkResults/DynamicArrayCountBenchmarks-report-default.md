
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WBRHZI : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Size    | Mean       | Error      | StdDev     | Median      | Allocated |
------- |-------- |-----------:|-----------:|-----------:|------------:|----------:|
 **Count**  | **1**       |  **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **10**      | **36.0000 ns** | **17.7248 ns** | **52.2620 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **100**     | **34.0000 ns** | **17.5270 ns** | **51.6789 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **1000**    |  **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **10000**   | **39.0000 ns** | **17.9689 ns** | **52.9818 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **100000**  | **52.0000 ns** | **17.6986 ns** | **52.1846 ns** | **100.0000 ns** |     **544 B** |
 **Count**  | **1000000** | **79.3814 ns** | **19.8620 ns** | **57.6233 ns** | **100.0000 ns** |     **544 B** |
