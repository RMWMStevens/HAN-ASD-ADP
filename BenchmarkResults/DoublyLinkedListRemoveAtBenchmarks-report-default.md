
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WBRHZI : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method         | Size    | Mean          | Error       | StdDev       | Median       | Allocated |
--------------- |-------- |--------------:|------------:|-------------:|-------------:|----------:|
 **RemoveAt_First** | **1**       |     **149.47 ns** |    **23.78 ns** |     **68.22 ns** |     **100.0 ns** |     **544 B** |
 RemoveAt_Mid   | 1       |     170.53 ns |    27.32 ns |     78.38 ns |     200.0 ns |     544 B |
 RemoveAt_Last  | 1       |     179.00 ns |    34.86 ns |    102.78 ns |     200.0 ns |     544 B |
 **RemoveAt_First** | **10**      |      **86.59 ns** |    **12.93 ns** |     **34.29 ns** |     **100.0 ns** |     **544 B** |
 RemoveAt_Mid   | 10      |     152.17 ns |    24.36 ns |     68.71 ns |     100.0 ns |     544 B |
 RemoveAt_Last  | 10      |      88.31 ns |    12.62 ns |     32.34 ns |     100.0 ns |     544 B |
 **RemoveAt_First** | **100**     |      **69.23 ns** |    **18.00 ns** |     **46.45 ns** |     **100.0 ns** |     **544 B** |
 RemoveAt_Mid   | 100     |     150.54 ns |    26.31 ns |     74.63 ns |     100.0 ns |     544 B |
 RemoveAt_Last  | 100     |     140.21 ns |    23.68 ns |     68.71 ns |     100.0 ns |     544 B |
 **RemoveAt_First** | **1000**    |     **132.29 ns** |    **22.77 ns** |     **65.69 ns** |     **100.0 ns** |     **544 B** |
 RemoveAt_Mid   | 1000    |     572.41 ns |    24.72 ns |     67.67 ns |     600.0 ns |     544 B |
 RemoveAt_Last  | 1000    |     128.26 ns |    24.84 ns |     70.05 ns |     100.0 ns |     544 B |
 **RemoveAt_First** | **10000**   |     **145.83 ns** |    **22.44 ns** |     **64.75 ns** |     **100.0 ns** |     **544 B** |
 RemoveAt_Mid   | 10000   |   4,469.23 ns |    75.50 ns |     63.04 ns |   4,500.0 ns |     544 B |
 RemoveAt_Last  | 10000   |     176.34 ns |    24.60 ns |     69.78 ns |     200.0 ns |     544 B |
 **RemoveAt_First** | **100000**  |     **328.57 ns** |    **39.38 ns** |    **114.87 ns** |     **300.0 ns** |     **544 B** |
 RemoveAt_Mid   | 100000  |  41,933.33 ns |   451.47 ns |    352.48 ns |  42,100.0 ns |     544 B |
 RemoveAt_Last  | 100000  |     320.10 ns |    36.62 ns |    106.23 ns |     350.0 ns |     544 B |
 **RemoveAt_First** | **1000000** |     **398.92 ns** |    **69.24 ns** |    **196.43 ns** |     **300.0 ns** |     **496 B** |
 RemoveAt_Mid   | 1000000 | 432,759.09 ns | 8,658.24 ns | 16,262.27 ns | 426,500.0 ns |     496 B |
 RemoveAt_Last  | 1000000 |     237.50 ns |    53.48 ns |    139.96 ns |     150.0 ns |    5664 B |
