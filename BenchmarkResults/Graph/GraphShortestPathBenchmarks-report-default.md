
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-TLKJGH : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method   | Mean     | Error     | StdDev    | Median   | Allocated |
--------- |---------:|----------:|----------:|---------:|----------:|
 Find_0_1 | 1.919 μs | 0.0959 μs | 0.2737 μs | 1.800 μs |   1.34 KB |
 Find_0_2 | 1.826 μs | 0.0478 μs | 0.1340 μs | 1.800 μs |   1.34 KB |
 Find_0_3 | 1.789 μs | 0.0483 μs | 0.1362 μs | 1.800 μs |   1.34 KB |
 Find_0_4 | 1.777 μs | 0.0552 μs | 0.1522 μs | 1.700 μs |   1.34 KB |
 Find_0_5 | 2.561 μs | 0.1769 μs | 0.5161 μs | 2.450 μs |   1.34 KB |
 Find_0_6 | 2.053 μs | 0.0986 μs | 0.2766 μs | 2.000 μs |   1.43 KB |
