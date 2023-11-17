
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-GGXILR : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method  | Times   | Mean        | Error      | StdDev      | Median      | Allocated |
-------- |-------- |------------:|-----------:|------------:|------------:|----------:|
 **IsEmpty** | **1**       |   **0.0000 ns** |  **0.0000 ns** |   **0.0000 ns** |   **0.0000 ns** |     **544 B** |
 **IsEmpty** | **100**     |  **52.0000 ns** | **21.2759 ns** |  **62.7324 ns** |   **0.0000 ns** |     **544 B** |
 **IsEmpty** | **10000**   |  **73.7374 ns** | **20.4267 ns** |  **59.9079 ns** | **100.0000 ns** |     **544 B** |
 **IsEmpty** | **1000000** | **327.3684 ns** | **90.8632 ns** | **260.7037 ns** | **200.0000 ns** |     **496 B** |
