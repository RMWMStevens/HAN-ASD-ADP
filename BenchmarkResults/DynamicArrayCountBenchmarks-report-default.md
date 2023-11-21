
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11370H 3.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-HSCGVF : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Length  | Times | Mean      | Error    | StdDev    | Median      | Allocated |
------- |-------- |------ |----------:|---------:|----------:|------------:|----------:|
 **Count**  | **100**     | **1**     |  **57.73 ns** | **23.77 ns** |  **68.97 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **10000**   | **1**     |  **48.98 ns** | **20.44 ns** |  **59.63 ns** |   **0.0000 ns** |     **544 B** |
 **Count**  | **1000000** | **1**     | **255.85 ns** | **57.86 ns** | **165.08 ns** | **250.0000 ns** |     **544 B** |
