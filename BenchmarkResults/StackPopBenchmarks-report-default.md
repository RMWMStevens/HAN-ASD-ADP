
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-RRQVFW : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Length | Times | Mean         | Error       | StdDev      | Allocated |
------- |------- |------ |-------------:|------------:|------------:|----------:|
 **Pop**    | **100**    | **1**     |     **405.4 ns** |    **49.96 ns** |   **140.93 ns** |     **968 B** |
 **Pop**    | **100**    | **10**    |     **802.4 ns** |    **31.10 ns** |    **83.56 ns** |    **4584 B** |
 **Pop**    | **100**    | **100**   |   **3,408.7 ns** |    **57.97 ns** |    **73.32 ns** |   **22944 B** |
 **Pop**    | **10000**  | **1**     |   **5,318.8 ns** |   **106.59 ns** |   **104.68 ns** |   **40568 B** |
 **Pop**    | **10000**  | **10**    |  **47,785.7 ns** |   **929.02 ns** |   **823.55 ns** |  **400584 B** |
 **Pop**    | **10000**  | **100**   | **465,615.4 ns** | **9,053.89 ns** | **7,560.41 ns** | **3982944 B** |
