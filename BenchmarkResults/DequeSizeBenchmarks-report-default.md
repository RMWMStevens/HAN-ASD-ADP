
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-GGXILR : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Times   | Mean      | Error    | StdDev    | Median      | Allocated |
------- |-------- |----------:|---------:|----------:|------------:|----------:|
 **Size**   | **1**       |  **44.44 ns** | **20.79 ns** |  **60.98 ns** |   **0.0000 ns** |     **544 B** |
 **Size**   | **100**     |  **46.46 ns** | **19.67 ns** |  **57.70 ns** |   **0.0000 ns** |     **544 B** |
 **Size**   | **10000**   |  **73.74 ns** | **22.10 ns** |  **64.82 ns** | **100.0000 ns** |     **544 B** |
 **Size**   | **1000000** | **315.38 ns** | **76.10 ns** | **213.40 ns** | **200.0000 ns** |     **496 B** |
