
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-HRDTVF : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method    | Size    | Mean      | Error     | StdDev    | Median      | Allocated |
---------- |-------- |----------:|----------:|----------:|------------:|----------:|
 **Get_First** | **100**     |  **43.00 ns** | **18.828 ns** | **55.514 ns** |   **0.0000 ns** |     **544 B** |
 Get_Mid   | 100     |  80.41 ns | 22.048 ns | 63.965 ns | 100.0000 ns |     544 B |
 Get_Last  | 100     |  32.00 ns | 18.595 ns | 54.828 ns |   0.0000 ns |     544 B |
 **Get_First** | **10000**   |  **34.00 ns** | **17.527 ns** | **51.679 ns** |   **0.0000 ns** |     **544 B** |
 Get_Mid   | 10000   |  80.95 ns | 14.705 ns | 39.504 ns | 100.0000 ns |     544 B |
 Get_Last  | 10000   |  68.00 ns | 20.383 ns | 60.101 ns | 100.0000 ns |     544 B |
 **Get_First** | **1000000** | **109.18 ns** | **27.001 ns** | **78.762 ns** | **100.0000 ns** |     **544 B** |
 Get_Mid   | 1000000 | 173.96 ns | 24.762 ns | 71.443 ns | 200.0000 ns |     544 B |
 Get_Last  | 1000000 | 100.00 ns |  0.000 ns |  0.000 ns | 100.0000 ns |     544 B |
