
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-GFXNRG : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method         | Size    | Mean          | Error        | StdDev       | Median       | Allocated |
--------------- |-------- |--------------:|-------------:|-------------:|-------------:|----------:|
 **RemoveAt_First** | **10**      |     **175.51 ns** |    **29.147 ns** |    **85.024 ns** |     **200.0 ns** |     **544 B** |
 RemoveAt_Mid   | 10      |     218.00 ns |    32.113 ns |    94.687 ns |     200.0 ns |     544 B |
 RemoveAt_Last  | 10      |     146.32 ns |    24.807 ns |    71.176 ns |     100.0 ns |     544 B |
 **RemoveAt_First** | **100**     |      **60.22 ns** |    **21.517 ns** |    **61.041 ns** |     **100.0 ns** |     **544 B** |
 RemoveAt_Mid   | 100     |     179.79 ns |    22.156 ns |    63.211 ns |     200.0 ns |     544 B |
 RemoveAt_Last  | 100     |     163.27 ns |    25.286 ns |    73.762 ns |     100.0 ns |     544 B |
 **RemoveAt_First** | **1000**    |     **130.00 ns** |    **36.870 ns** |   **108.711 ns** |     **100.0 ns** |     **544 B** |
 RemoveAt_Mid   | 1000    |     618.68 ns |    29.557 ns |    82.882 ns |     600.0 ns |     544 B |
 RemoveAt_Last  | 1000    |     100.00 ns |     0.000 ns |     0.000 ns |     100.0 ns |     544 B |
 **RemoveAt_First** | **10000**   |     **156.52 ns** |    **28.453 ns** |    **80.253 ns** |     **100.0 ns** |     **544 B** |
 RemoveAt_Mid   | 10000   |   4,447.06 ns |    85.155 ns |    87.447 ns |   4,400.0 ns |     544 B |
 RemoveAt_Last  | 10000   |     224.00 ns |    32.737 ns |    96.525 ns |     200.0 ns |     544 B |
 **RemoveAt_First** | **100000**  |     **302.06 ns** |    **28.135 ns** |    **81.623 ns** |     **300.0 ns** |     **544 B** |
 RemoveAt_Mid   | 100000  |  42,357.89 ns |   783.937 ns |   871.344 ns |  42,300.0 ns |     544 B |
 RemoveAt_Last  | 100000  |     343.16 ns |    32.013 ns |    91.852 ns |     300.0 ns |     544 B |
 **RemoveAt_First** | **1000000** |     **394.85 ns** |    **89.049 ns** |   **258.349 ns** |     **300.0 ns** |     **496 B** |
 RemoveAt_Mid   | 1000000 | 427,284.21 ns | 8,546.464 ns | 9,499.372 ns | 422,900.0 ns |     496 B |
 RemoveAt_Last  | 1000000 |     520.00 ns |   103.266 ns |   296.289 ns |     400.0 ns |     496 B |
