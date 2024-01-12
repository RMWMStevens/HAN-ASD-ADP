
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-EXFOWV : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method  | Length | Times | Mean       | Error    | StdDev    | Median     |
-------- |------- |------ |-----------:|---------:|----------:|-----------:|
 **FindMin** | **100**    | **1**     |   **150.5 ns** | **19.71 ns** |  **57.81 ns** |   **100.0 ns** |
 **FindMin** | **10000**  | **1**     | **1,030.2 ns** | **76.62 ns** | **221.06 ns** | **1,000.0 ns** |
