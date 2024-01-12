
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-EXFOWV : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Times | Length | Mean        | Error       | StdDev     | Median      |
------- |------ |------- |------------:|------------:|-----------:|------------:|
 **Remove** | **1**     | **100**    |    **426.9 ns** |    **53.29 ns** |   **151.2 ns** |    **400.0 ns** |
 **Remove** | **1**     | **10000**  |  **5,358.1 ns** |    **92.90 ns** |   **211.6 ns** |  **5,300.0 ns** |
 **Remove** | **5**     | **100**    |  **1,670.9 ns** |    **45.41 ns** |   **123.5 ns** |  **1,600.0 ns** |
 **Remove** | **5**     | **10000**  | **29,574.7 ns** | **1,444.64 ns** | **4,145.0 ns** | **27,400.0 ns** |
 **Remove** | **10**    | **100**    |  **3,798.9 ns** |   **158.54 ns** |   **436.7 ns** |  **3,700.0 ns** |
 **Remove** | **10**    | **10000**  | **41,529.2 ns** |   **740.61 ns** |   **963.0 ns** | **41,400.0 ns** |
