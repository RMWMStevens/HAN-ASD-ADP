
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-FJSBUM : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Length  | Times | Mean      | Error    | StdDev    | Median   | Allocated |
------- |-------- |------ |----------:|---------:|----------:|---------:|----------:|
 **Count**  | **100**     | **1**     |  **58.59 ns** | **19.49 ns** |  **57.16 ns** | **100.0 ns** |     **544 B** |
 **Count**  | **10000**   | **1**     |  **78.49 ns** | **14.56 ns** |  **41.31 ns** | **100.0 ns** |     **544 B** |
 **Count**  | **1000000** | **1**     | **371.88 ns** | **76.88 ns** | **221.81 ns** | **300.0 ns** |     **496 B** |
