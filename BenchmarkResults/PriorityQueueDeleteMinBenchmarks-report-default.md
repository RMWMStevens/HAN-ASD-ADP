
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-GPMNUC : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method    | Length | Times | Mean          | Error        | StdDev       | Median        | Allocated |
---------- |------- |------ |--------------:|-------------:|-------------:|--------------:|----------:|
 **DeleteMin** | **10000**  | **1**     |      **44.02 μs** |     **0.837 μs** |     **1.819 μs** |      **43.50 μs** |     **584 B** |
 **DeleteMin** | **10000**  | **100**   |   **4,359.17 μs** |    **84.631 μs** |   **185.766 μs** |   **4,288.30 μs** |    **4544 B** |
 **DeleteMin** | **10000**  | **10000** | **234,328.53 μs** | **4,622.489 μs** | **7,594.882 μs** | **232,699.90 μs** |  **400496 B** |
