
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-TLKJGH : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                       | Mean     | Error     | StdDev    | Allocated |
----------------------------- |---------:|----------:|----------:|----------:|
 LoadLijnlijst                | 2.503 μs | 0.0517 μs | 0.0834 μs |   2.74 KB |
 LoadVerbindingslijst         | 3.484 μs | 0.1192 μs | 0.3160 μs |   3.37 KB |
 LoadVerbindingsmatrix        | 3.226 μs | 0.0659 μs | 0.1748 μs |   3.37 KB |
 LoadLijnlijstGewogen         | 2.902 μs | 0.0620 μs | 0.1293 μs |   2.49 KB |
 LoadVerbindingslijstGewogen  | 2.704 μs | 0.0574 μs | 0.1376 μs |   2.49 KB |
 LoadVerbindingsmatrixGewogen | 2.753 μs | 0.0701 μs | 0.1908 μs |   2.49 KB |
