
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-HRDTVF : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method            | Size    | Mean          | Error         | StdDev        | Median       | Allocated |
------------------ |-------- |--------------:|--------------:|--------------:|-------------:|----------:|
 **Get_First**         | **100**     |      **75.00 ns** |     **23.306 ns** |     **68.718 ns** |     **100.0 ns** |     **544 B** |
 Get_25perc        | 100     |     100.00 ns |      0.000 ns |      0.000 ns |     100.0 ns |     544 B |
 Get_Half          | 100     |     163.64 ns |     23.082 ns |     67.695 ns |     200.0 ns |     544 B |
 Get_75perc        | 100     |      73.08 ns |     17.295 ns |     44.643 ns |     100.0 ns |     544 B |
 Get_Last          | 100     |      90.62 ns |     23.629 ns |     68.176 ns |     100.0 ns |     544 B |
 Get_First_NoTail  | 100     |      61.86 ns |     23.569 ns |     68.379 ns |     100.0 ns |     544 B |
 Get_25perc_NoTail | 100     |      76.40 ns |     15.410 ns |     42.700 ns |     100.0 ns |     544 B |
 Get_Half_NoTail   | 100     |     127.55 ns |     19.555 ns |     57.042 ns |     100.0 ns |     544 B |
 Get_75perc_NoTail | 100     |     149.49 ns |     20.303 ns |     59.545 ns |     100.0 ns |     544 B |
 Get_Last_NoTail   | 100     |     177.55 ns |     23.365 ns |     68.158 ns |     200.0 ns |     544 B |
 **Get_First**         | **10000**   |      **72.37 ns** |     **17.685 ns** |     **45.015 ns** |     **100.0 ns** |     **544 B** |
 Get_25perc        | 10000   |   2,400.00 ns |     48.353 ns |     64.550 ns |   2,400.0 ns |     544 B |
 Get_Half          | 10000   |   4,408.33 ns |     85.632 ns |     66.856 ns |   4,400.0 ns |     544 B |
 Get_75perc        | 10000   |   2,233.33 ns |     45.334 ns |     48.507 ns |   2,200.0 ns |     544 B |
 Get_Last          | 10000   |     127.00 ns |     25.442 ns |     75.015 ns |     100.0 ns |     544 B |
 Get_First_NoTail  | 10000   |      76.32 ns |     16.814 ns |     42.797 ns |     100.0 ns |     544 B |
 Get_25perc_NoTail | 10000   |   2,225.86 ns |     47.038 ns |     68.947 ns |   2,250.0 ns |     544 B |
 Get_Half_NoTail   | 10000   |   4,450.00 ns |     73.374 ns |     65.044 ns |   4,500.0 ns |     544 B |
 Get_75perc_NoTail | 10000   |   6,541.67 ns |    101.566 ns |     79.296 ns |   6,500.0 ns |     544 B |
 Get_Last_NoTail   | 10000   |   8,553.85 ns |    115.852 ns |     96.742 ns |   8,600.0 ns |     544 B |
 **Get_First**         | **1000000** |     **331.18 ns** |     **95.125 ns** |    **269.854 ns** |     **200.0 ns** |     **496 B** |
 Get_25perc        | 1000000 | 224,328.57 ns |  4,485.782 ns |  8,202.507 ns | 223,600.0 ns |     496 B |
 Get_Half          | 1000000 | 454,601.28 ns |  9,088.219 ns | 23,459.595 ns | 450,700.0 ns |     496 B |
 Get_75perc        | 1000000 | 222,813.24 ns |  4,431.632 ns | 10,617.908 ns | 220,450.0 ns |     496 B |
 Get_Last          | 1000000 |     415.38 ns |     82.001 ns |    229.939 ns |     300.0 ns |     496 B |
 Get_First_NoTail  | 1000000 |     323.16 ns |    114.325 ns |    328.019 ns |     150.0 ns |     496 B |
 Get_25perc_NoTail | 1000000 | 222,315.28 ns |  4,436.362 ns | 10,965.588 ns | 220,350.0 ns |     496 B |
 Get_Half_NoTail   | 1000000 | 444,298.63 ns |  8,877.375 ns | 22,107.744 ns | 446,200.0 ns |     496 B |
 Get_75perc_NoTail | 1000000 | 662,650.00 ns | 13,231.332 ns | 34,154.294 ns | 654,600.0 ns |     496 B |
 Get_Last_NoTail   | 1000000 | 890,069.62 ns | 17,805.050 ns | 46,277.691 ns | 881,600.0 ns |     496 B |
