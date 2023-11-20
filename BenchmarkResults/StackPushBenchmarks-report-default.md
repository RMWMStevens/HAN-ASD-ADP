
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-RRQVFW : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Length | Times | Mean         | Error       | StdDev      | Allocated |
------- |------- |------ |-------------:|------------:|------------:|----------:|
 **Push**   | **100**    | **1**     |     **390.9 ns** |    **26.76 ns** |    **73.71 ns** |     **976 B** |
 **Push**   | **100**    | **10**    |     **910.5 ns** |    **25.23 ns** |    **68.65 ns** |    **5024 B** |
 **Push**   | **100**    | **100**   |   **8,594.7 ns** |   **170.90 ns** |   **189.95 ns** |   **63344 B** |
 **Push**   | **10000**  | **1**     |   **5,258.3 ns** |   **104.53 ns** |   **174.64 ns** |   **40528 B** |
 **Push**   | **10000**  | **10**    |  **48,111.1 ns** |   **940.19 ns** | **1,318.02 ns** |  **400976 B** |
 **Push**   | **10000**  | **100**   | **474,907.7 ns** | **8,558.64 ns** | **7,146.85 ns** | **4023344 B** |
