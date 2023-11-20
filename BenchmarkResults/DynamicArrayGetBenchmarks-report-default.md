
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WSLHHA : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method    | Length  | Times | Mean      | Error    | StdDev   | Median      | Allocated |
---------- |-------- |------ |----------:|---------:|---------:|------------:|----------:|
 **Get_First** | **100**     | **1**     |  **40.00 ns** | **17.38 ns** | **51.25 ns** |   **0.0000 ns** |     **544 B** |
 Get_Mid   | 100     | 1     |  54.00 ns | 19.53 ns | 57.59 ns |  50.0000 ns |     544 B |
 Get_Last  | 100     | 1     |  33.00 ns | 19.32 ns | 56.95 ns |   0.0000 ns |     544 B |
 **Get_First** | **10000**   | **1**     |  **52.00 ns** | **19.57 ns** | **57.70 ns** |   **0.0000 ns** |     **544 B** |
 Get_Mid   | 10000   | 1     |  80.00 ns | 14.02 ns | 40.21 ns | 100.0000 ns |     544 B |
 Get_Last  | 10000   | 1     |  71.72 ns | 21.25 ns | 62.34 ns | 100.0000 ns |     544 B |
 **Get_First** | **1000000** | **1**     |  **84.81 ns** | **13.90 ns** | **36.12 ns** | **100.0000 ns** |     **544 B** |
 Get_Mid   | 1000000 | 1     | 131.96 ns | 22.55 ns | 65.43 ns | 100.0000 ns |     544 B |
 Get_Last  | 1000000 | 1     | 126.80 ns | 21.41 ns | 62.11 ns | 100.0000 ns |     544 B |
