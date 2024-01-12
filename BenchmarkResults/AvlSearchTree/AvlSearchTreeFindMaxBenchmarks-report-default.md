
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-EXFOWV : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method  | Length | Times | Mean      | Error    | StdDev    | Median   |
-------- |------- |------ |----------:|---------:|----------:|---------:|
 **FindMin** | **100**    | **1**     |  **61.00 ns** | **19.81 ns** |  **58.42 ns** | **100.0 ns** |
 **FindMin** | **10000**  | **1**     | **857.14 ns** | **63.61 ns** | **185.56 ns** | **800.0 ns** |
