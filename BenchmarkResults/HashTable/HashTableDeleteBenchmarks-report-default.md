
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-LNRJDX : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                  | Times | Mean       | Error    | StdDev    | Median     | Allocated |
------------------------ |------ |-----------:|---------:|----------:|-----------:|----------:|
 **Delete_SeparateChaining** | **1**     |   **689.6 ns** | **50.16 ns** | **144.72 ns** |   **650.0 ns** |     **544 B** |
 Delete_LinearProbing    | 1     |   722.4 ns | 47.61 ns | 138.87 ns |   700.0 ns |     544 B |
 Delete_QuadraticProbing | 1     |   612.1 ns | 30.92 ns |  86.71 ns |   600.0 ns |     544 B |
 **Delete_SeparateChaining** | **5**     | **1,117.2 ns** | **72.09 ns** | **211.43 ns** | **1,100.0 ns** |     **544 B** |
 Delete_LinearProbing    | 5     | 1,061.3 ns | 63.45 ns | 180.00 ns | 1,000.0 ns |     544 B |
 Delete_QuadraticProbing | 5     | 1,042.3 ns | 68.73 ns | 199.39 ns | 1,000.0 ns |     544 B |
 **Delete_SeparateChaining** | **10**    | **1,130.2 ns** | **33.39 ns** |  **90.84 ns** | **1,100.0 ns** |     **544 B** |
 Delete_LinearProbing    | 10    | 1,564.2 ns | 88.04 ns | 252.61 ns | 1,500.0 ns |     544 B |
 Delete_QuadraticProbing | 10    | 1,400.0 ns | 99.36 ns | 285.09 ns | 1,300.0 ns |     544 B |
