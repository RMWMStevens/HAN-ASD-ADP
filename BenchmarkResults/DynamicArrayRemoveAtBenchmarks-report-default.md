
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WBRHZI : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method         | Size    | Mean          | Error       | StdDev      | Median          | Allocated |
--------------- |-------- |--------------:|------------:|------------:|----------------:|----------:|
 **RemoveAt_First** | **1**       |      **45.00 ns** |    **18.28 ns** |    **53.89 ns** |       **0.0000 ns** |     **880 B** |
 RemoveAt_Mid   | 1       |      63.00 ns |    20.82 ns |    61.39 ns |     100.0000 ns |     544 B |
 RemoveAt_Last  | 1       |      58.59 ns |    20.67 ns |    60.63 ns |     100.0000 ns |     544 B |
 **RemoveAt_First** | **10**      |      **55.56 ns** |    **20.21 ns** |    **59.29 ns** |     **100.0000 ns** |     **544 B** |
 RemoveAt_Mid   | 10      |      63.00 ns |    21.91 ns |    64.60 ns |     100.0000 ns |     544 B |
 RemoveAt_Last  | 10      |      84.00 ns |    22.47 ns |    66.24 ns |     100.0000 ns |     544 B |
 **RemoveAt_First** | **100**     |      **92.21 ns** |    **10.53 ns** |    **26.98 ns** |     **100.0000 ns** |     **544 B** |
 RemoveAt_Mid   | 100     |      72.73 ns |    21.68 ns |    63.60 ns |     100.0000 ns |     544 B |
 RemoveAt_Last  | 100     |      60.61 ns |    21.13 ns |    61.97 ns |     100.0000 ns |     544 B |
 **RemoveAt_First** | **1000**    |     **482.02 ns** |    **22.14 ns** |    **61.35 ns** |     **500.0000 ns** |     **544 B** |
 RemoveAt_Mid   | 1000    |     275.28 ns |    24.50 ns |    67.89 ns |     300.0000 ns |     544 B |
 RemoveAt_Last  | 1000    |      56.00 ns |    21.19 ns |    62.47 ns |       0.0000 ns |     544 B |
 **RemoveAt_First** | **10000**   |   **4,567.86 ns** |    **46.69 ns** |    **66.96 ns** |   **4,600.0000 ns** |     **544 B** |
 RemoveAt_Mid   | 10000   |   2,314.29 ns |    48.15 ns |    57.32 ns |   2,300.0000 ns |     544 B |
 RemoveAt_Last  | 10000   |      62.00 ns |    18.53 ns |    54.64 ns |     100.0000 ns |     544 B |
 **RemoveAt_First** | **100000**  |  **45,800.00 ns** |   **819.53 ns** |   **684.35 ns** |  **45,800.0000 ns** |     **544 B** |
 RemoveAt_Mid   | 100000  |  22,057.14 ns |   175.40 ns |   155.49 ns |  22,000.0000 ns |     544 B |
 RemoveAt_Last  | 100000  |      60.00 ns |    20.45 ns |    60.30 ns |     100.0000 ns |     544 B |
 **RemoveAt_First** | **1000000** | **460,966.67 ns** | **6,080.08 ns** | **4,746.93 ns** | **461,350.0000 ns** |     **544 B** |
 RemoveAt_Mid   | 1000000 | 230,725.00 ns | 4,443.95 ns | 5,117.66 ns | 230,550.0000 ns |     544 B |
 RemoveAt_Last  | 1000000 |      91.75 ns |    23.16 ns |    67.19 ns |     100.0000 ns |     544 B |
