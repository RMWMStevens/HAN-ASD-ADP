
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-FJSBUM : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Length | Times | Mean         | Error       | StdDev      | Median       | Allocated |
------- |------- |------ |-------------:|------------:|------------:|-------------:|----------:|
 **Pop**    | **100**    | **1**     |     **412.8 ns** |    **25.30 ns** |    **72.19 ns** |     **400.0 ns** |     **968 B** |
 **Pop**    | **100**    | **10**    |     **802.5 ns** |    **30.17 ns** |    **78.41 ns** |     **800.0 ns** |    **4584 B** |
 **Pop**    | **100**    | **100**   |   **3,577.4 ns** |    **73.13 ns** |   **111.68 ns** |   **3,500.0 ns** |   **22944 B** |
 **Pop**    | **10000**  | **1**     |   **5,260.9 ns** |   **105.23 ns** |   **202.73 ns** |   **5,200.0 ns** |   **40520 B** |
 **Pop**    | **10000**  | **10**    |  **48,093.5 ns** |   **939.09 ns** | **1,434.09 ns** |  **47,600.0 ns** |  **400536 B** |
 **Pop**    | **10000**  | **100**   | **466,078.9 ns** | **6,599.45 ns** | **7,335.27 ns** | **466,600.0 ns** | **3982944 B** |
