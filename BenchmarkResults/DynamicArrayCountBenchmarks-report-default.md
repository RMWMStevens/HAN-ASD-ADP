
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-GFXNRG : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Size    | Mean       | Error      | StdDev     | Median      | Allocated |
------- |-------- |-----------:|-----------:|-----------:|------------:|----------:|
 **Count**  | **1**       | **30.0000 ns** | **16.3471 ns** | **48.1999 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **10**      | **45.0000 ns** | **18.2767 ns** | **53.8891 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **100**     |  **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **1000**    |  **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **10000**   |  **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **100000**  | **33.0000 ns** | **16.7370 ns** | **49.3493 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **1000000** | **76.8421 ns** | **25.1394 ns** | **72.1297 ns** | **100.0000 ns** |     **544 B** |
