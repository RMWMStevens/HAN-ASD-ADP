
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WBRHZI : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Size    | Mean        | Error      | StdDev      | Median      | Allocated |
------- |-------- |------------:|-----------:|------------:|------------:|----------:|
 **Count**  | **1**       |  **41.4141 ns** | **19.4900 ns** |  **57.1609 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **10**      |   **0.0000 ns** |  **0.0000 ns** |   **0.0000 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **100**     |  **43.0000 ns** | **19.4351 ns** |  **57.3048 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **1000**    |   **0.0000 ns** |  **0.0000 ns** |   **0.0000 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **10000**   |  **60.0000 ns** | **22.6102 ns** |  **66.6667 ns** |  **50.0000 ns** |     **544 B** |
 **Count**  | **100000**  | **128.5714 ns** | **21.4567 ns** |  **62.5901 ns** | **100.0000 ns** |     **544 B** |
 **Count**  | **1000000** | **306.0000 ns** | **82.9100 ns** | **244.4619 ns** | **200.0000 ns** |     **496 B** |
