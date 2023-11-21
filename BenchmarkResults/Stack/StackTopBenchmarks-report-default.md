
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-FJSBUM : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Length | Times | Mean      | Error    | StdDev    | Median   | Allocated |
------- |------- |------ |----------:|---------:|----------:|---------:|----------:|
 **Top**    | **100**    | **1**     |  **71.00 ns** | **20.05 ns** |  **59.11 ns** | **100.0 ns** |     **544 B** |
 **Top**    | **100**    | **10**    | **144.00 ns** | **21.19 ns** |  **62.47 ns** | **100.0 ns** |     **544 B** |
 **Top**    | **100**    | **100**   | **436.08 ns** | **19.39 ns** |  **56.25 ns** | **400.0 ns** |     **544 B** |
 **Top**    | **10000**  | **1**     | **271.58 ns** | **65.24 ns** | **187.18 ns** | **200.0 ns** |     **496 B** |
 **Top**    | **10000**  | **10**    | **220.41 ns** | **36.49 ns** | **106.45 ns** | **200.0 ns** |     **496 B** |
 **Top**    | **10000**  | **100**   | **437.11 ns** | **42.89 ns** | **124.43 ns** | **400.0 ns** |     **496 B** |
