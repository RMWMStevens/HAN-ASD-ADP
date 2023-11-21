
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-FJSBUM : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method            | Length  | Times | Mean          | Error         | StdDev        | Median       | Allocated |
------------------ |-------- |------ |--------------:|--------------:|--------------:|-------------:|----------:|
 **Get_First**         | **100**     | **1**     |      **80.61 ns** |     **21.263 ns** |     **62.025 ns** |     **100.0 ns** |     **544 B** |
 Get_25perc        | 100     | 1     |     136.00 ns |     31.433 ns |     92.682 ns |     100.0 ns |     544 B |
 Get_Half          | 100     | 1     |      87.65 ns |     12.565 ns |     33.101 ns |     100.0 ns |     544 B |
 Get_75perc        | 100     | 1     |      69.62 ns |     17.807 ns |     46.283 ns |     100.0 ns |     544 B |
 Get_Last          | 100     | 1     |      68.42 ns |     18.383 ns |     46.792 ns |     100.0 ns |     544 B |
 Get_First_NoTail  | 100     | 1     |      75.51 ns |     25.129 ns |     73.304 ns |     100.0 ns |     544 B |
 Get_25perc_NoTail | 100     | 1     |      72.73 ns |     17.488 ns |     44.828 ns |     100.0 ns |     544 B |
 Get_Half_NoTail   | 100     | 1     |     151.52 ns |     20.873 ns |     61.218 ns |     100.0 ns |     544 B |
 Get_75perc_NoTail | 100     | 1     |     158.16 ns |     21.413 ns |     62.464 ns |     200.0 ns |     544 B |
 Get_Last_NoTail   | 100     | 1     |     182.29 ns |     21.333 ns |     61.550 ns |     200.0 ns |     544 B |
 **Get_First**         | **10000**   | **1**     |      **68.42 ns** |     **18.383 ns** |     **46.792 ns** |     **100.0 ns** |     **544 B** |
 Get_25perc        | 10000   | 1     |   2,328.57 ns |     47.093 ns |     56.061 ns |   2,300.0 ns |     544 B |
 Get_Half          | 10000   | 1     |   4,261.54 ns |     77.893 ns |     65.044 ns |   4,300.0 ns |     544 B |
 Get_75perc        | 10000   | 1     |   2,200.00 ns |      0.000 ns |      0.000 ns |   2,200.0 ns |     544 B |
 Get_Last          | 10000   | 1     |      76.00 ns |     17.014 ns |     42.996 ns |     100.0 ns |     544 B |
 Get_First_NoTail  | 10000   | 1     |      93.59 ns |      9.550 ns |     24.652 ns |     100.0 ns |     544 B |
 Get_25perc_NoTail | 10000   | 1     |   2,276.19 ns |     45.274 ns |     53.896 ns |   2,300.0 ns |     544 B |
 Get_Half_NoTail   | 10000   | 1     |   4,408.33 ns |     36.975 ns |     28.868 ns |   4,400.0 ns |     544 B |
 Get_75perc_NoTail | 10000   | 1     |   7,928.57 ns |     93.113 ns |     82.542 ns |   7,900.0 ns |     544 B |
 Get_Last_NoTail   | 10000   | 1     |   8,515.38 ns |     95.880 ns |     80.064 ns |   8,500.0 ns |     544 B |
 **Get_First**         | **1000000** | **1**     |     **328.42 ns** |    **109.470 ns** |    **314.089 ns** |     **200.0 ns** |     **496 B** |
 Get_25perc        | 1000000 | 1     | 223,166.07 ns |  4,442.816 ns |  9,563.630 ns | 221,600.0 ns |     496 B |
 Get_Half          | 1000000 | 1     | 435,331.82 ns |  8,568.307 ns | 16,093.358 ns | 429,550.0 ns |     496 B |
 Get_75perc        | 1000000 | 1     | 221,615.79 ns |  4,431.372 ns |  9,633.439 ns | 221,700.0 ns |     496 B |
 Get_Last          | 1000000 | 1     |     654.55 ns |     98.059 ns |    287.591 ns |     600.0 ns |     496 B |
 Get_First_NoTail  | 1000000 | 1     |     306.25 ns |    104.622 ns |    301.858 ns |     200.0 ns |    5888 B |
 Get_25perc_NoTail | 1000000 | 1     | 218,674.47 ns |  4,221.774 ns |  8,234.246 ns | 216,300.0 ns |     496 B |
 Get_Half_NoTail   | 1000000 | 1     | 434,315.00 ns |  8,664.407 ns | 15,400.975 ns | 433,600.0 ns |     496 B |
 Get_75perc_NoTail | 1000000 | 1     | 665,409.86 ns | 13,260.972 ns | 32,529.390 ns | 654,000.0 ns |     496 B |
 Get_Last_NoTail   | 1000000 | 1     | 884,380.77 ns | 17,433.382 ns | 36,002.958 ns | 872,000.0 ns |     496 B |
