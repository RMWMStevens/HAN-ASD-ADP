
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-DNLSZU : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Size    | Times | Mean      | Error    | StdDev   | Median      | Allocated |
------- |-------- |------ |----------:|---------:|---------:|------------:|----------:|
 **Count**  | **100**     | **1**     |  **39.00 ns** | **17.97 ns** | **52.98 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **10000**   | **1**     |  **40.00 ns** | **18.04 ns** | **53.18 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **1000000** | **1**     | **107.14 ns** | **27.52 ns** | **80.27 ns** | **100.0000 ns** |     **544 B** |
