
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-FJSBUM : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method    | Length  | Times | Mean      | Error    | StdDev   | Median      | Allocated |
---------- |-------- |------ |----------:|---------:|---------:|------------:|----------:|
 **Get_First** | **100**     | **1**     |  **49.00 ns** | **20.16 ns** | **59.45 ns** |   **0.0000 ns** |     **544 B** |
 Get_Mid   | 100     | 1     |  51.00 ns | 20.16 ns | 59.45 ns |   0.0000 ns |     544 B |
 Get_Last  | 100     | 1     |  78.79 ns | 20.82 ns | 61.07 ns | 100.0000 ns |     544 B |
 **Get_First** | **10000**   | **1**     |  **45.00 ns** | **17.63 ns** | **51.98 ns** |   **0.0000 ns** |     **544 B** |
 Get_Mid   | 10000   | 1     |  64.00 ns | 20.18 ns | 59.49 ns | 100.0000 ns |     544 B |
 Get_Last  | 10000   | 1     |  52.00 ns | 19.57 ns | 57.70 ns |   0.0000 ns |     544 B |
 **Get_First** | **1000000** | **1**     | **122.92 ns** | **29.95 ns** | **86.43 ns** | **100.0000 ns** |     **544 B** |
 Get_Mid   | 1000000 | 1     |  80.41 ns | 25.19 ns | 73.09 ns | 100.0000 ns |     544 B |
 Get_Last  | 1000000 | 1     | 154.64 ns | 23.35 ns | 67.73 ns | 100.0000 ns |     544 B |
