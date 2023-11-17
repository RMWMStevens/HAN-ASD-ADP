
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2
  Job-VWFLJL : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | ArraySize | Mean       | Error      | StdDev     | Median |
------- |---------- |-----------:|-----------:|-----------:|-------:|
 **Count**  | **1**         | **39.0000 ns** | **19.2187 ns** | **56.6667 ns** | **0.0 ns** |
 **Count**  | **10**        | **42.0000 ns** | **18.7814 ns** | **55.3775 ns** | **0.0 ns** |
 **Count**  | **100**       |  **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** | **0.0 ns** |
 **Count**  | **1000**      |  **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** | **0.0 ns** |
 **Count**  | **10000**     | **28.5714 ns** | **15.5663 ns** | **45.4077 ns** | **0.0 ns** |
