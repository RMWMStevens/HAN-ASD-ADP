
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-NNKNHT : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method   | Mean      | Error     | StdDev   | Median   | Allocated |
--------- |----------:|----------:|---------:|---------:|----------:|
 Find_0_1 |  8.738 μs | 0.8092 μs | 2.295 μs | 7.800 μs |   1.34 KB |
 Find_0_2 | 10.374 μs | 1.2846 μs | 3.747 μs | 9.250 μs |   1.34 KB |
 Find_0_3 |  8.493 μs | 0.5748 μs | 1.621 μs | 8.150 μs |   1.34 KB |
 Find_0_4 | 10.520 μs | 0.9857 μs | 2.764 μs | 9.950 μs |   1.34 KB |
