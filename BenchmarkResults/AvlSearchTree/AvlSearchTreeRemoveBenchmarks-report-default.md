
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-NNKNHT : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Times | Length | Mean        | Error       | StdDev      | Median      |
------- |------ |------- |------------:|------------:|------------:|------------:|
 **Remove** | **1**     | **100**    |    **644.4 ns** |    **29.01 ns** |    **80.88 ns** |    **600.0 ns** |
 **Remove** | **1**     | **10000**  |  **9,400.0 ns** |   **335.19 ns** |   **961.71 ns** |  **9,500.0 ns** |
 **Remove** | **5**     | **100**    |  **2,594.5 ns** |    **55.55 ns** |   **138.33 ns** |  **2,600.0 ns** |
 **Remove** | **5**     | **10000**  | **37,666.3 ns** |   **819.71 ns** | **2,312.00 ns** | **37,050.0 ns** |
 **Remove** | **10**    | **100**    |  **5,263.2 ns** |    **99.74 ns** |   **216.82 ns** |  **5,200.0 ns** |
 **Remove** | **10**    | **10000**  | **54,900.0 ns** | **1,100.70 ns** | **1,898.65 ns** | **54,450.0 ns** |
