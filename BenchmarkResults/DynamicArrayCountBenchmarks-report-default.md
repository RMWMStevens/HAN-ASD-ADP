
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WSLHHA : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Length  | Times | Mean      | Error    | StdDev   | Median      | Allocated |
------- |-------- |------ |----------:|---------:|---------:|------------:|----------:|
 **Count**  | **100**     | **1**     |  **40.00 ns** | **16.70 ns** | **49.24 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **10000**   | **1**     |  **46.00 ns** | **17.66 ns** | **52.07 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **1000000** | **1**     | **116.33 ns** | **22.39 ns** | **65.32 ns** | **100.0000 ns** |     **544 B** |
