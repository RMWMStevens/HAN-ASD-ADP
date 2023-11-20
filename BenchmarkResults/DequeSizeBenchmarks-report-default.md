
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-ZZBLTY : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Times | Length | Mean     | Error    | StdDev   | Median      | Allocated |
------- |------ |------- |---------:|---------:|---------:|------------:|----------:|
 **Size**   | **1**     | **1**      | **77.01 ns** | **15.46 ns** | **42.32 ns** | **100.0000 ns** |     **544 B** |
 **Size**   | **1**     | **100**    | **79.00 ns** | **19.46 ns** | **57.38 ns** | **100.0000 ns** |     **544 B** |
 **Size**   | **1**     | **10000**  | **30.00 ns** | **16.35 ns** | **48.20 ns** |   **0.0000 ns** |     **544 B** |
