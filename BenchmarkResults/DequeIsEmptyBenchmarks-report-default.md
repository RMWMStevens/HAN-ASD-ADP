
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-ZZBLTY : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method  | Times | Length | Mean     | Error    | StdDev   | Median      | Allocated |
-------- |------ |------- |---------:|---------:|---------:|------------:|----------:|
 **IsEmpty** | **1**     | **1**      | **50.00 ns** | **18.98 ns** | **55.96 ns** |   **0.0000 ns** |     **544 B** |
 **IsEmpty** | **1**     | **100**    | **69.00 ns** | **20.28 ns** | **59.79 ns** | **100.0000 ns** |     **544 B** |
 **IsEmpty** | **1**     | **10000**  | **57.58 ns** | **20.72 ns** | **60.76 ns** | **100.0000 ns** |     **544 B** |
