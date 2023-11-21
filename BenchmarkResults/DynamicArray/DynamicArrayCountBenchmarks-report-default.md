
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-FJSBUM : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Length  | Times | Mean      | Error    | StdDev   | Median      | Allocated |
------- |-------- |------ |----------:|---------:|---------:|------------:|----------:|
 **Count**  | **100**     | **1**     |  **51.00 ns** | **17.71 ns** | **52.21 ns** |  **50.0000 ns** |     **544 B** |
 **Count**  | **10000**   | **1**     |  **46.00 ns** | **18.93 ns** | **55.81 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **1000000** | **1**     | **115.46 ns** | **22.98 ns** | **66.68 ns** | **100.0000 ns** |     **544 B** |
