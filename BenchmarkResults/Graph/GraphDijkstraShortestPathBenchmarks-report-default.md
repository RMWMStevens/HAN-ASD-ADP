
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-TLKJGH : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method   | Mean     | Error     | StdDev    | Median   | Allocated |
--------- |---------:|----------:|----------:|---------:|----------:|
 Find_0_1 | 2.213 μs | 0.0713 μs | 0.1952 μs | 2.200 μs |   1.34 KB |
 Find_0_2 | 1.961 μs | 0.0411 μs | 0.0910 μs | 2.000 μs |   1.38 KB |
 Find_0_3 | 2.434 μs | 0.0602 μs | 0.1648 μs | 2.400 μs |   1.38 KB |
 Find_0_4 | 2.108 μs | 0.0496 μs | 0.1375 μs | 2.100 μs |   1.38 KB |
