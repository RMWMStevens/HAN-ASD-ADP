
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-RRQVFW : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Length | Times | Mean      | Error    | StdDev   | Median      | Allocated |
------- |------- |------ |----------:|---------:|---------:|------------:|----------:|
 **Top**    | **100**    | **1**     |  **48.00 ns** | **20.72 ns** | **61.10 ns** |   **0.0000 ns** |     **544 B** |
 **Top**    | **100**    | **10**    | **135.00 ns** | **22.29 ns** | **65.71 ns** | **100.0000 ns** |     **544 B** |
 **Top**    | **100**    | **100**   | **386.59 ns** | **12.93 ns** | **34.29 ns** | **400.0000 ns** |     **544 B** |
 **Top**    | **10000**  | **1**     | **137.21 ns** | **28.22 ns** | **76.77 ns** | **100.0000 ns** |     **496 B** |
 **Top**    | **10000**  | **10**    | **204.35 ns** | **29.22 ns** | **82.43 ns** | **200.0000 ns** |     **496 B** |
 **Top**    | **10000**  | **100**   | **423.91 ns** | **32.56 ns** | **91.83 ns** | **400.0000 ns** |     **496 B** |
