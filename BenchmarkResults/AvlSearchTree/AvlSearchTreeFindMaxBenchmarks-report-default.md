
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-NNKNHT : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method  | Length | Times | Mean       | Error     | StdDev   |
-------- |------- |------ |-----------:|----------:|---------:|
 **FindMax** | **100**    | **1**     |   **691.8 ns** |  **53.62 ns** | **156.4 ns** |
 **FindMax** | **10000**  | **1**     | **5,080.5 ns** | **216.41 ns** | **620.9 ns** |
