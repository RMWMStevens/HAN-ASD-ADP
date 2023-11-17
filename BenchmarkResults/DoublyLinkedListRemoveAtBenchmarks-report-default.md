
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-HRDTVF : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method         | Size    | Mean         | Error       | StdDev       | Median       | Allocated |
--------------- |-------- |-------------:|------------:|-------------:|-------------:|----------:|
 **RemoveAt_First** | **100**     |     **143.4 ns** |    **23.94 ns** |     **70.22 ns** |     **100.0 ns** |     **544 B** |
 RemoveAt_Mid   | 100     |     171.2 ns |    17.40 ns |     45.55 ns |     200.0 ns |     544 B |
 RemoveAt_Last  | 100     |     100.0 ns |     0.00 ns |      0.00 ns |     100.0 ns |     544 B |
 **RemoveAt_First** | **10000**   |     **119.5 ns** |    **23.34 ns** |     **66.96 ns** |     **150.0 ns** |     **544 B** |
 RemoveAt_Mid   | 10000   |   4,437.5 ns |    90.12 ns |     88.51 ns |   4,400.0 ns |     544 B |
 RemoveAt_Last  | 10000   |     181.2 ns |    29.03 ns |     83.74 ns |     150.0 ns |     544 B |
 **RemoveAt_First** | **1000000** |     **435.7 ns** |   **133.93 ns** |    **390.68 ns** |     **200.0 ns** |     **496 B** |
 RemoveAt_Mid   | 1000000 | 439,975.9 ns | 8,745.91 ns | 18,448.09 ns | 435,250.0 ns |     496 B |
 RemoveAt_Last  | 1000000 |     532.6 ns |    91.65 ns |    253.96 ns |     500.0 ns |     496 B |
