
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-FJSBUM : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method  | Length | Times | Mean           | Error         | StdDev        | Median         | Allocated |
-------- |------- |------ |---------------:|--------------:|--------------:|---------------:|----------:|
 **FindMin** | **100**    | **1**     |       **1.264 μs** |     **0.0771 μs** |     **0.2225 μs** |       **1.200 μs** |     **584 B** |
 **FindMin** | **100**    | **100**   |      **42.717 μs** |     **0.4629 μs** |     **0.3614 μs** |      **42.700 μs** |    **4544 B** |
 **FindMin** | **100**    | **10000** |   **4,562.377 μs** |    **84.5402 μs** |   **158.7870 μs** |   **4,578.050 μs** |  **400544 B** |
 **FindMin** | **10000**  | **1**     |      **41.058 μs** |     **0.6587 μs** |     **0.5143 μs** |      **41.000 μs** |     **584 B** |
 **FindMin** | **10000**  | **100**   |   **4,111.014 μs** |    **70.4498 μs** |    **62.4519 μs** |   **4,095.050 μs** |    **4544 B** |
 **FindMin** | **10000**  | **10000** | **444,835.760 μs** | **8,366.4290 μs** | **7,825.9628 μs** | **447,223.300 μs** |  **406096 B** |
