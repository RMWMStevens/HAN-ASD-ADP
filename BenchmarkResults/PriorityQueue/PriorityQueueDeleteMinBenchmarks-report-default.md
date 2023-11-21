
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-FJSBUM : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method    | Length | Times | Mean          | Error        | StdDev       | Median        | Allocated |
---------- |------- |------ |--------------:|-------------:|-------------:|--------------:|----------:|
 **DeleteMin** | **10000**  | **1**     |      **42.42 μs** |     **0.596 μs** |     **0.662 μs** |      **42.30 μs** |     **584 B** |
 **DeleteMin** | **10000**  | **100**   |   **4,253.93 μs** |    **79.964 μs** |   **154.063 μs** |   **4,174.50 μs** |    **4544 B** |
 **DeleteMin** | **10000**  | **10000** | **228,644.16 μs** | **3,677.028 μs** | **3,070.485 μs** | **229,004.50 μs** |  **400496 B** |
