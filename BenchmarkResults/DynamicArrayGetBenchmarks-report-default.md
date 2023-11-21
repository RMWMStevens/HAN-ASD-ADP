
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11370H 3.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-HSCGVF : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method    | Length  | Times | Mean        | Error      | StdDev      | Median      | Allocated |
---------- |-------- |------ |------------:|-----------:|------------:|------------:|----------:|
 **Get_First** | **100**     | **1**     |   **0.0000 ns** |  **0.0000 ns** |   **0.0000 ns** |   **0.0000 ns** |     **544 B** |
 Get_Mid   | 100     | 1     |   0.0000 ns |  0.0000 ns |   0.0000 ns |   0.0000 ns |     544 B |
 Get_Last  | 100     | 1     |  67.7419 ns | 23.9088 ns |  67.8254 ns | 100.0000 ns |     544 B |
 **Get_First** | **10000**   | **1**     |  **67.6768 ns** | **21.1359 ns** |  **61.9880 ns** | **100.0000 ns** |     **544 B** |
 Get_Mid   | 10000   | 1     |  36.1842 ns |  8.8426 ns |  22.5073 ns |  50.0000 ns |     544 B |
 Get_Last  | 10000   | 1     | 108.0000 ns | 31.4924 ns |  92.8559 ns | 100.0000 ns |     544 B |
 **Get_First** | **1000000** | **1**     | **341.0526 ns** | **61.9509 ns** | **177.7488 ns** | **300.0000 ns** |     **544 B** |
 Get_Mid   | 1000000 | 1     | 437.1134 ns | 72.4936 ns | 210.3170 ns | 400.0000 ns |     544 B |
 Get_Last  | 1000000 | 1     | 342.4242 ns | 65.1857 ns | 191.1784 ns | 300.0000 ns |     544 B |
