
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-HRDTVF : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method         | Size    | Mean          | Error        | StdDev       | Median       | Allocated |
--------------- |-------- |--------------:|-------------:|-------------:|-------------:|----------:|
 **RemoveAt_First** | **100**     |      **75.56 ns** |    **15.503 ns** |    **43.216 ns** |     **100.0 ns** |     **544 B** |
 RemoveAt_Mid   | 100     |     100.00 ns |     0.000 ns |     0.000 ns |     100.0 ns |     544 B |
 RemoveAt_Last  | 100     |      60.00 ns |    20.452 ns |    60.302 ns |     100.0 ns |     544 B |
 **RemoveAt_First** | **10000**   |   **4,492.31 ns** |    **33.214 ns** |    **27.735 ns** |   **4,500.0 ns** |     **544 B** |
 RemoveAt_Mid   | 10000   |   2,325.00 ns |    46.753 ns |    60.792 ns |   2,300.0 ns |     544 B |
 RemoveAt_Last  | 10000   |      85.06 ns |    13.099 ns |    35.857 ns |     100.0 ns |     544 B |
 **RemoveAt_First** | **1000000** | **467,925.00 ns** | **4,982.074 ns** | **7,145.142 ns** | **466,500.0 ns** |     **544 B** |
 RemoveAt_Mid   | 1000000 | 235,257.45 ns | 3,630.092 ns | 7,080.216 ns | 233,900.0 ns |     544 B |
 RemoveAt_Last  | 1000000 |      94.05 ns |     8.860 ns |    23.802 ns |     100.0 ns |     544 B |
