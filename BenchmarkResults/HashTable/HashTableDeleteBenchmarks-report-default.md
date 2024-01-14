
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-NNKNHT : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                  | Times | Mean     | Error     | StdDev    | Median   | Allocated |
------------------------ |------ |---------:|----------:|----------:|---------:|----------:|
 **Delete_SeparateChaining** | **1**     | **1.980 μs** | **0.1495 μs** | **0.4264 μs** | **1.900 μs** |     **544 B** |
 Delete_LinearProbing    | 1     | 1.980 μs | 0.1397 μs | 0.3848 μs | 1.850 μs |     544 B |
 Delete_QuadraticProbing | 1     | 1.802 μs | 0.0916 μs | 0.2553 μs | 1.800 μs |     544 B |
 **Delete_SeparateChaining** | **5**     | **2.560 μs** | **0.1527 μs** | **0.4382 μs** | **2.500 μs** |     **544 B** |
 Delete_LinearProbing    | 5     | 2.778 μs | 0.1885 μs | 0.5318 μs | 2.700 μs |     544 B |
 Delete_QuadraticProbing | 5     | 2.593 μs | 0.1919 μs | 0.5350 μs | 2.500 μs |     544 B |
 **Delete_SeparateChaining** | **10**    | **3.216 μs** | **0.1798 μs** | **0.4982 μs** | **3.200 μs** |     **544 B** |
 Delete_LinearProbing    | 10    | 3.068 μs | 0.1686 μs | 0.4783 μs | 3.100 μs |     544 B |
 Delete_QuadraticProbing | 10    | 2.802 μs | 0.1922 μs | 0.5453 μs | 2.700 μs |     544 B |
