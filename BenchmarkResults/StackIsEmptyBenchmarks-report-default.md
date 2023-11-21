
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11370H 3.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-OHILME : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method  | Times | Length | Mean      | Error    | StdDev    | Median    | Allocated |
-------- |------ |------- |----------:|---------:|----------:|----------:|----------:|
 **IsEmpty** | **1**     | **100**    |  **85.00 ns** | **21.76 ns** |  **64.16 ns** | **100.00 ns** |     **544 B** |
 **IsEmpty** | **1**     | **10000**  | **162.77 ns** | **53.90 ns** | **153.79 ns** |  **50.00 ns** |     **544 B** |
