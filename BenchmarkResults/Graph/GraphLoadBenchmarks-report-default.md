
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-NNKNHT : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                       | Mean      | Error     | StdDev   | Median    | Allocated |
----------------------------- |----------:|----------:|---------:|----------:|----------:|
 LoadLijnlijst                | 10.699 μs | 0.7821 μs | 2.193 μs | 10.100 μs |    2.7 KB |
 LoadVerbindingslijst         | 11.949 μs | 0.8453 μs | 2.342 μs | 11.200 μs |   3.32 KB |
 LoadVerbindingsmatrix        | 12.618 μs | 0.8396 μs | 2.396 μs | 11.500 μs |   3.32 KB |
 LoadLijnlijstGewogen         |  9.819 μs | 0.7679 μs | 2.153 μs |  9.350 μs |   2.45 KB |
 LoadVerbindingslijstGewogen  | 13.341 μs | 1.3712 μs | 3.978 μs | 12.200 μs |   2.45 KB |
 LoadVerbindingsmatrixGewogen |  9.416 μs | 0.5307 μs | 1.514 μs |  8.900 μs |   2.45 KB |
