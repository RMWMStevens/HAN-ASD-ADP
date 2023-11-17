
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WSLHHA : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method            | Length  | Times | Mean          | Error        | StdDev       | Median       | Allocated |
------------------ |-------- |------ |--------------:|-------------:|-------------:|-------------:|----------:|
 **Get_First**         | **100**     | **1**     |      **65.00 ns** |     **21.76 ns** |     **64.16 ns** |     **100.0 ns** |     **544 B** |
 Get_25perc        | 100     | 1     |      84.00 ns |     14.60 ns |     36.91 ns |     100.0 ns |     544 B |
 Get_Half          | 100     | 1     |     132.65 ns |     21.33 ns |     62.22 ns |     100.0 ns |     544 B |
 Get_75perc        | 100     | 1     |      80.00 ns |     15.93 ns |     40.27 ns |     100.0 ns |     544 B |
 Get_Last          | 100     | 1     |      74.39 ns |     16.56 ns |     43.92 ns |     100.0 ns |     544 B |
 Get_First_NoTail  | 100     | 1     |      79.59 ns |     20.27 ns |     59.13 ns |     100.0 ns |     544 B |
 Get_25perc_NoTail | 100     | 1     |      68.83 ns |     18.19 ns |     46.62 ns |     100.0 ns |     544 B |
 Get_Half_NoTail   | 100     | 1     |     162.00 ns |     24.48 ns |     72.17 ns |     100.0 ns |     544 B |
 Get_75perc_NoTail | 100     | 1     |     144.00 ns |     21.19 ns |     62.47 ns |     100.0 ns |     544 B |
 Get_Last_NoTail   | 100     | 1     |     187.00 ns |     25.80 ns |     76.08 ns |     200.0 ns |     544 B |
 **Get_First**         | **10000**   | **1**     |      **70.41 ns** |     **23.20 ns** |     **67.67 ns** |     **100.0 ns** |     **544 B** |
 Get_25perc        | 10000   | 1     |   2,278.26 ns |     47.42 ns |     59.97 ns |   2,300.0 ns |     544 B |
 Get_Half          | 10000   | 1     |   4,500.00 ns |     90.35 ns |     84.52 ns |   4,500.0 ns |     544 B |
 Get_75perc        | 10000   | 1     |   2,401.04 ns |     85.42 ns |    246.45 ns |   2,300.0 ns |     544 B |
 Get_Last          | 10000   | 1     |     156.57 ns |     29.69 ns |     87.09 ns |     200.0 ns |     544 B |
 Get_First_NoTail  | 10000   | 1     |      87.06 ns |     12.49 ns |     33.76 ns |     100.0 ns |     544 B |
 Get_25perc_NoTail | 10000   | 1     |   2,247.83 ns |     46.90 ns |     59.31 ns |   2,200.0 ns |     544 B |
 Get_Half_NoTail   | 10000   | 1     |   4,430.77 ns |     89.94 ns |     75.11 ns |   4,400.0 ns |     544 B |
 Get_75perc_NoTail | 10000   | 1     |   6,606.25 ns |    133.89 ns |    131.50 ns |   6,650.0 ns |     544 B |
 Get_Last_NoTail   | 10000   | 1     |   8,607.69 ns |    114.25 ns |     95.41 ns |   8,600.0 ns |     544 B |
 **Get_First**         | **1000000** | **1**     |     **363.40 ns** |    **125.53 ns** |    **364.19 ns** |     **150.0 ns** |     **496 B** |
 Get_25perc        | 1000000 | 1     | 219,952.86 ns |  4,352.93 ns | 10,595.64 ns | 217,250.0 ns |     496 B |
 Get_Half          | 1000000 | 1     | 445,628.87 ns |  8,872.70 ns | 25,741.33 ns | 436,600.0 ns |     496 B |
 Get_75perc        | 1000000 | 1     | 214,600.00 ns |  4,283.07 ns |  6,540.69 ns | 214,400.0 ns |     496 B |
 Get_Last          | 1000000 | 1     |     662.24 ns |     93.21 ns |    271.88 ns |     600.0 ns |     496 B |
 Get_First_NoTail  | 1000000 | 1     |     283.72 ns |     71.06 ns |    193.34 ns |     200.0 ns |     496 B |
 Get_25perc_NoTail | 1000000 | 1     | 219,190.00 ns |  4,336.64 ns |  8,760.24 ns | 218,900.0 ns |     496 B |
 Get_Half_NoTail   | 1000000 | 1     | 443,456.94 ns |  8,783.19 ns | 21,709.87 ns | 442,350.0 ns |     496 B |
 Get_75perc_NoTail | 1000000 | 1     | 669,130.67 ns | 13,385.14 ns | 33,825.95 ns | 662,300.0 ns |     496 B |
 Get_Last_NoTail   | 1000000 | 1     | 856,000.00 ns | 16,702.74 ns | 14,806.55 ns | 855,500.0 ns |     496 B |
