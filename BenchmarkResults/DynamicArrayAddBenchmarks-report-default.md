
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-HRDTVF : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method | Size    | Mean         | Error       | StdDev      | Median      | Allocated |
------- |-------- |-------------:|------------:|------------:|------------:|----------:|
 **Add**    | **3**       |     **78.95 ns** |    **16.12 ns** |    **41.04 ns** |    **100.0 ns** |     **544 B** |
 **Add**    | **4**       |    **418.39 ns** |    **27.02 ns** |    **73.97 ns** |    **400.0 ns** |     **600 B** |
 **Add**    | **5**       |    **114.00 ns** |    **20.46 ns** |    **60.34 ns** |    **100.0 ns** |     **544 B** |
 **Add**    | **65535**   |    **122.00 ns** |    **20.21 ns** |    **59.59 ns** |    **100.0 ns** |     **544 B** |
 **Add**    | **65536**   | **53,984.00 ns** | **1,072.45 ns** | **1,431.69 ns** | **53,700.0 ns** |  **524856 B** |
 **Add**    | **65537**   |     **81.00 ns** |    **20.28 ns** |    **59.79 ns** |    **100.0 ns** |     **544 B** |
 **Add**    | **1000000** |    **164.13 ns** |    **27.60 ns** |    **77.86 ns** |    **200.0 ns** |     **544 B** |
