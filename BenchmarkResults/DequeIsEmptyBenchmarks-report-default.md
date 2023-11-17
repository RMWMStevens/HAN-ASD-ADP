
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WSLHHA : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method  | Times | Length | Mean     | Error    | StdDev   | Median      | Allocated |
-------- |------ |------- |---------:|---------:|---------:|------------:|----------:|
 **IsEmpty** | **1**     | **0**      | **78.65 ns** | **14.87 ns** | **41.21 ns** | **100.0000 ns** |     **544 B** |
 **IsEmpty** | **1**     | **100**    | **47.00 ns** | **21.26 ns** | **62.69 ns** |   **0.0000 ns** |     **544 B** |
 **IsEmpty** | **1**     | **10000**  | **80.00 ns** | **14.43 ns** | **40.22 ns** | **100.0000 ns** |     **544 B** |
