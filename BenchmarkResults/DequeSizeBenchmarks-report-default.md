
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-BIRKPB : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Times | Length | Mean     | Error    | StdDev   | Median   | Allocated |
------- |------ |------- |---------:|---------:|---------:|---------:|----------:|
 **Size**   | **1**     | **0**      | **72.73 ns** | **20.56 ns** | **60.30 ns** | **100.0 ns** |     **544 B** |
 **Size**   | **1**     | **1000**   | **64.00 ns** | **21.84 ns** | **64.39 ns** | **100.0 ns** |     **544 B** |
