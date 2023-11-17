
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-HRDTVF : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Size    | Mean       | Error    | StdDev    | Median     | Allocated |
------- |-------- |-----------:|---------:|----------:|-----------:|----------:|
 **Add**    | **3**       |   **458.0 ns** | **54.14 ns** | **149.11 ns** |   **400.0 ns** |     **584 B** |
 **Add**    | **4**       |   **421.5 ns** | **24.39 ns** |  **63.39 ns** |   **400.0 ns** |     **584 B** |
 **Add**    | **5**       |   **560.2 ns** | **77.17 ns** | **225.10 ns** |   **500.0 ns** |     **584 B** |
 **Add**    | **65535**   |   **586.0 ns** | **60.30 ns** | **171.05 ns** |   **500.0 ns** |     **584 B** |
 **Add**    | **65536**   |   **661.6 ns** | **73.82 ns** | **216.52 ns** |   **600.0 ns** |     **584 B** |
 **Add**    | **65537**   |   **627.8 ns** | **67.25 ns** | **195.12 ns** |   **600.0 ns** |     **584 B** |
 **Add**    | **1000000** | **1,038.1 ns** | **72.86 ns** | **211.37 ns** | **1,000.0 ns** |     **536 B** |
