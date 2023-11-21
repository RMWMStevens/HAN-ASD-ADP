
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-FJSBUM : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method         | Times | Length  | Mean            | Error        | StdDev       | Median         | Allocated |
--------------- |------ |-------- |----------------:|-------------:|-------------:|---------------:|----------:|
 **RemoveAt_First** | **1**     | **100**     |       **168.00 ns** |     **25.45 ns** |     **75.05 ns** |       **200.0 ns** |     **544 B** |
 RemoveAt_Mid   | 1     | 100     |       148.96 ns |     25.14 ns |     72.54 ns |       100.0 ns |     544 B |
 RemoveAt_Last  | 1     | 100     |       128.57 ns |     25.10 ns |     73.22 ns |       100.0 ns |     544 B |
 **RemoveAt_First** | **1**     | **10000**   |       **145.36 ns** |     **20.53 ns** |     **59.55 ns** |       **100.0 ns** |     **544 B** |
 RemoveAt_Mid   | 1     | 10000   |     4,508.33 ns |     85.63 ns |     66.86 ns |     4,500.0 ns |     544 B |
 RemoveAt_Last  | 1     | 10000   |       173.68 ns |     24.49 ns |     70.27 ns |       200.0 ns |     544 B |
 **RemoveAt_First** | **1**     | **1000000** |       **328.42 ns** |     **73.26 ns** |    **210.20 ns** |       **300.0 ns** |     **496 B** |
 RemoveAt_Mid   | 1     | 1000000 |   436,866.67 ns |  8,656.60 ns | 17,087.29 ns |   431,150.0 ns |     496 B |
 RemoveAt_Last  | 1     | 1000000 |       185.87 ns |     70.04 ns |    197.56 ns |       100.0 ns |     496 B |
 **RemoveAt_First** | **5**     | **100**     |       **179.35 ns** |     **22.63 ns** |     **63.83 ns** |       **200.0 ns** |     **544 B** |
 RemoveAt_Mid   | 5     | 100     |       400.00 ns |     34.46 ns |    100.51 ns |       400.0 ns |     544 B |
 RemoveAt_Last  | 5     | 100     |       137.63 ns |     29.82 ns |     84.59 ns |       100.0 ns |     544 B |
 **RemoveAt_First** | **5**     | **10000**   |       **228.57 ns** |     **28.70 ns** |     **83.73 ns** |       **200.0 ns** |     **544 B** |
 RemoveAt_Mid   | 5     | 10000   |    20,671.43 ns |    218.69 ns |    193.86 ns |    20,650.0 ns |     544 B |
 RemoveAt_Last  | 5     | 10000   |       171.28 ns |     24.98 ns |     71.27 ns |       200.0 ns |     544 B |
 **RemoveAt_First** | **5**     | **1000000** |       **477.08 ns** |     **62.10 ns** |    **179.17 ns** |       **400.0 ns** |     **496 B** |
 RemoveAt_Mid   | 5     | 1000000 | 2,158,570.59 ns | 43,040.55 ns | 69,502.47 ns | 2,135,100.0 ns |     496 B |
 RemoveAt_Last  | 5     | 1000000 |       422.09 ns |     80.41 ns |    218.77 ns |       400.0 ns |     496 B |
 **RemoveAt_First** | **10**    | **100**     |       **254.64 ns** |     **21.70 ns** |     **62.95 ns** |       **200.0 ns** |     **544 B** |
 RemoveAt_Mid   | 10    | 100     |       615.79 ns |     27.05 ns |     77.62 ns |       600.0 ns |     544 B |
 RemoveAt_Last  | 10    | 100     |        79.22 ns |     15.93 ns |     40.84 ns |       100.0 ns |     544 B |
 **RemoveAt_First** | **10**    | **10000**   |       **408.60 ns** |     **27.82 ns** |     **78.93 ns** |       **400.0 ns** |     **544 B** |
 RemoveAt_Mid   | 10    | 10000   |    40,892.31 ns |    221.15 ns |    184.67 ns |    40,900.0 ns |     544 B |
 RemoveAt_Last  | 10    | 10000   |       135.05 ns |     24.39 ns |     70.77 ns |       100.0 ns |     544 B |
 **RemoveAt_First** | **10**    | **1000000** |       **413.98 ns** |     **49.74 ns** |    **141.11 ns** |       **400.0 ns** |     **496 B** |
 RemoveAt_Mid   | 10    | 1000000 | 4,316,758.82 ns | 81,587.58 ns | 83,784.44 ns | 4,293,100.0 ns |     496 B |
 RemoveAt_Last  | 10    | 1000000 |       525.00 ns |     98.93 ns |    285.44 ns |       400.0 ns |     496 B |
