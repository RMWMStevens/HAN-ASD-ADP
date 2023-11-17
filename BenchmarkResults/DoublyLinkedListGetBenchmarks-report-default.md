
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-BIRKPB : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method            | Length  | Times | Mean          | Error         | StdDev        | Median          | Allocated |
------------------ |-------- |------ |--------------:|--------------:|--------------:|----------------:|----------:|
 **Get_First**         | **100**     | **1**     |      **35.71 ns** |     **21.029 ns** |     **61.342 ns** |       **0.0000 ns** |     **544 B** |
 Get_25perc        | 100     | 1     |     115.15 ns |     30.946 ns |     90.761 ns |     100.0000 ns |     544 B |
 Get_Half          | 100     | 1     |     143.00 ns |     30.585 ns |     90.179 ns |     100.0000 ns |     544 B |
 Get_75perc        | 100     | 1     |      58.00 ns |     24.189 ns |     71.322 ns |       0.0000 ns |     544 B |
 Get_Last          | 100     | 1     |     148.00 ns |     30.670 ns |     90.431 ns |     150.0000 ns |     544 B |
 Get_First_NoTail  | 100     | 1     |     131.31 ns |     24.668 ns |     72.346 ns |     100.0000 ns |     544 B |
 Get_25perc_NoTail | 100     | 1     |     152.00 ns |     25.725 ns |     75.852 ns |     100.0000 ns |     544 B |
 Get_Half_NoTail   | 100     | 1     |     147.00 ns |     26.162 ns |     77.140 ns |     100.0000 ns |     544 B |
 Get_75perc_NoTail | 100     | 1     |     100.00 ns |      0.000 ns |      0.000 ns |     100.0000 ns |     544 B |
 Get_Last_NoTail   | 100     | 1     |     161.00 ns |     22.556 ns |     66.507 ns |     200.0000 ns |     544 B |
 **Get_First**         | **10000**   | **1**     |     **100.00 ns** |      **0.000 ns** |      **0.000 ns** |     **100.0000 ns** |     **544 B** |
 Get_25perc        | 10000   | 1     |   2,252.63 ns |     46.153 ns |     51.299 ns |   2,300.0000 ns |     544 B |
 Get_Half          | 10000   | 1     |   4,380.77 ns |     87.714 ns |    120.064 ns |   4,400.0000 ns |     544 B |
 Get_75perc        | 10000   | 1     |   2,206.90 ns |     44.405 ns |     65.088 ns |   2,200.0000 ns |     544 B |
 Get_Last          | 10000   | 1     |      85.33 ns |     14.093 ns |     35.616 ns |     100.0000 ns |     544 B |
 Get_First_NoTail  | 10000   | 1     |      90.82 ns |     22.604 ns |     65.938 ns |     100.0000 ns |     544 B |
 Get_25perc_NoTail | 10000   | 1     |   2,231.82 ns |     46.243 ns |     56.790 ns |   2,200.0000 ns |     544 B |
 Get_Half_NoTail   | 10000   | 1     |   4,430.77 ns |     89.943 ns |     75.107 ns |   4,400.0000 ns |     544 B |
 Get_75perc_NoTail | 10000   | 1     |   6,550.00 ns |     74.358 ns |     73.030 ns |   6,550.0000 ns |     544 B |
 Get_Last_NoTail   | 10000   | 1     |   8,680.00 ns |    122.560 ns |    114.642 ns |   8,700.0000 ns |     544 B |
 **Get_First**         | **1000000** | **1**     |     **386.87 ns** |    **113.573 ns** |    **333.089 ns** |     **200.0000 ns** |     **496 B** |
 Get_25perc        | 1000000 | 1     | 212,608.33 ns |  3,977.361 ns |  3,105.262 ns | 212,800.0000 ns |     496 B |
 Get_Half          | 1000000 | 1     | 445,066.25 ns |  8,893.756 ns | 23,273.410 ns | 437,650.0000 ns |     496 B |
 Get_75perc        | 1000000 | 1     | 217,157.89 ns |  4,278.254 ns |  4,755.268 ns | 216,400.0000 ns |     496 B |
 Get_Last          | 1000000 | 1     |     577.08 ns |     93.473 ns |    269.690 ns |     500.0000 ns |     496 B |
 Get_First_NoTail  | 1000000 | 1     |     324.21 ns |    119.304 ns |    342.306 ns |     200.0000 ns |     496 B |
 Get_25perc_NoTail | 1000000 | 1     | 221,604.00 ns |  4,434.684 ns | 11,207.013 ns | 219,500.0000 ns |     496 B |
 Get_Half_NoTail   | 1000000 | 1     | 445,202.56 ns |  8,550.879 ns | 22,072.548 ns | 443,950.0000 ns |     496 B |
 Get_75perc_NoTail | 1000000 | 1     | 641,883.33 ns |  9,400.971 ns |  7,339.660 ns | 641,950.0000 ns |     496 B |
 Get_Last_NoTail   | 1000000 | 1     | 868,906.67 ns | 17,098.698 ns | 32,532.050 ns | 858,800.0000 ns |     496 B |
