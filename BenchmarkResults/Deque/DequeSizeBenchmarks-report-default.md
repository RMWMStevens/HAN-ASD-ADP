
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-FJSBUM : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Times | Length | Mean     | Error    | StdDev   | Median   | Allocated |
------- |------ |------- |---------:|---------:|---------:|---------:|----------:|
 **Size**   | **1**     | **1**      | **65.66 ns** | **21.87 ns** | **64.15 ns** | **100.0 ns** |     **544 B** |
 **Size**   | **1**     | **100**    | **81.00 ns** | **19.70 ns** | **58.08 ns** | **100.0 ns** |     **544 B** |
 **Size**   | **1**     | **10000**  | **86.05 ns** | **12.81 ns** | **34.85 ns** | **100.0 ns** |     **544 B** |
