
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-NNKNHT : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method   | Mean     | Error     | StdDev   | Median   | Allocated |
--------- |---------:|----------:|---------:|---------:|----------:|
 Find_0_1 | 7.164 μs | 0.6000 μs | 1.673 μs | 6.850 μs |    1.3 KB |
 Find_0_2 | 7.206 μs | 0.6554 μs | 1.901 μs | 6.500 μs |   1.43 KB |
 Find_0_3 | 8.426 μs | 0.8253 μs | 2.341 μs | 8.100 μs |    1.3 KB |
 Find_0_4 | 7.115 μs | 0.7091 μs | 2.023 μs | 6.400 μs |    1.3 KB |
 Find_0_5 | 7.438 μs | 0.6595 μs | 1.882 μs | 6.900 μs |    1.3 KB |
 Find_0_6 | 7.345 μs | 0.5573 μs | 1.599 μs | 6.900 μs |   1.38 KB |
