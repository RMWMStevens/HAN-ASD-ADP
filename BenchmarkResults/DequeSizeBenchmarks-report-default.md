
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WSLHHA : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Times | Length | Mean     | Error    | StdDev   | Median   | Allocated |
------- |------ |------- |---------:|---------:|---------:|---------:|----------:|
 **Size**   | **1**     | **0**      | **67.68 ns** | **18.76 ns** | **55.01 ns** | **100.0 ns** |     **544 B** |
 **Size**   | **1**     | **100**    | **67.00 ns** | **20.48 ns** | **60.39 ns** | **100.0 ns** |     **544 B** |
 **Size**   | **1**     | **10000**  | **89.90 ns** | **22.05 ns** | **64.67 ns** | **100.0 ns** |     **544 B** |
