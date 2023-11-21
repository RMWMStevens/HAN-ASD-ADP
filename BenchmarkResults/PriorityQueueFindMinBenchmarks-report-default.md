
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-GPMNUC : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method  | Length | Times | Mean           | Error         | StdDev         | Allocated |
-------- |------- |------ |---------------:|--------------:|---------------:|----------:|
 **FindMin** | **100**    | **1**     |       **1.122 μs** |     **0.0521 μs** |      **0.1452 μs** |     **584 B** |
 **FindMin** | **100**    | **100**   |      **42.350 μs** |     **0.7439 μs** |      **0.5808 μs** |    **4544 B** |
 **FindMin** | **100**    | **10000** |   **4,543.411 μs** |    **89.9563 μs** |    **193.6404 μs** |  **400544 B** |
 **FindMin** | **10000**  | **1**     |      **41.385 μs** |     **0.3346 μs** |      **0.2794 μs** |     **584 B** |
 **FindMin** | **10000**  | **100**   |   **4,113.021 μs** |    **49.7634 μs** |     **44.1140 μs** |    **4544 B** |
 **FindMin** | **10000**  | **10000** | **446,836.133 μs** | **8,097.7661 μs** | **11,869.6005 μs** |  **400496 B** |