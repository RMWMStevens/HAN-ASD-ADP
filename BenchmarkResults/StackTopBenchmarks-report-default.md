
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11370H 3.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-OHILME : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Length | Times | Mean      | Error    | StdDev    | Median   | Allocated |
------- |------- |------ |----------:|---------:|----------:|---------:|----------:|
 **Top**    | **100**    | **1**     |  **66.67 ns** | **23.36 ns** |  **68.51 ns** | **100.0 ns** |     **544 B** |
 **Top**    | **100**    | **10**    | **137.37 ns** | **24.15 ns** |  **70.83 ns** | **100.0 ns** |     **544 B** |
 **Top**    | **100**    | **100**   | **272.41 ns** | **16.42 ns** |  **44.95 ns** | **300.0 ns** |     **544 B** |
 **Top**    | **10000**  | **1**     | **412.63 ns** | **71.04 ns** | **203.82 ns** | **300.0 ns** |     **544 B** |
 **Top**    | **10000**  | **10**    | **331.58 ns** | **49.10 ns** | **140.87 ns** | **300.0 ns** |     **544 B** |
 **Top**    | **10000**  | **100**   | **592.78 ns** | **72.14 ns** | **209.29 ns** | **500.0 ns** |     **544 B** |
