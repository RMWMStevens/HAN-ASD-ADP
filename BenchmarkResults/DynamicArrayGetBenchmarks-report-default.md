
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-DNLSZU : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method    | Size    | Times | Mean      | Error    | StdDev   | Median      | Allocated |
---------- |-------- |------ |----------:|---------:|---------:|------------:|----------:|
 **Get_First** | **100**     | **1**     |  **51.00 ns** | **20.16 ns** | **59.45 ns** |   **0.0000 ns** |     **544 B** |
 Get_Mid   | 100     | 1     |  58.16 ns | 20.25 ns | 59.07 ns | 100.0000 ns |     544 B |
 Get_Last  | 100     | 1     |  61.00 ns | 22.04 ns | 64.97 ns | 100.0000 ns |     544 B |
 **Get_First** | **10000**   | **1**     |  **55.00 ns** | **18.90 ns** | **55.73 ns** | **100.0000 ns** |     **544 B** |
 Get_Mid   | 10000   | 1     |  92.31 ns | 10.39 ns | 26.82 ns | 100.0000 ns |     544 B |
 Get_Last  | 10000   | 1     |  63.00 ns | 18.45 ns | 54.41 ns | 100.0000 ns |     544 B |
 **Get_First** | **1000000** | **1**     |  **69.33 ns** | **18.37 ns** | **46.42 ns** | **100.0000 ns** |     **544 B** |
 Get_Mid   | 1000000 | 1     | 121.05 ns | 23.79 ns | 68.25 ns | 100.0000 ns |     544 B |
 Get_Last  | 1000000 | 1     | 133.67 ns | 21.42 ns | 62.50 ns | 100.0000 ns |     544 B |
