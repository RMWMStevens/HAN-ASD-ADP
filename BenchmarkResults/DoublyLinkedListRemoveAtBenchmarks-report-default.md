
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WSLHHA : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method         | Times | Length  | Mean            | Error         | StdDev         | Median         | Allocated |
--------------- |------ |-------- |----------------:|--------------:|---------------:|---------------:|----------:|
 **RemoveAt_First** | **1**     | **100**     |        **85.19 ns** |     **13.569 ns** |      **35.746 ns** |       **100.0 ns** |     **544 B** |
 RemoveAt_Mid   | 1     | 100     |       140.82 ns |     25.501 ns |      74.386 ns |       100.0 ns |     544 B |
 RemoveAt_Last  | 1     | 100     |        75.32 ns |     16.929 ns |      43.395 ns |       100.0 ns |     544 B |
 **RemoveAt_First** | **1**     | **10000**   |       **164.95 ns** |     **22.821 ns** |      **66.209 ns** |       **200.0 ns** |     **544 B** |
 RemoveAt_Mid   | 1     | 10000   |     4,392.86 ns |     82.354 ns |      73.005 ns |     4,400.0 ns |     544 B |
 RemoveAt_Last  | 1     | 10000   |       156.25 ns |     27.458 ns |      79.223 ns |       100.0 ns |     544 B |
 **RemoveAt_First** | **1**     | **1000000** |       **492.63 ns** |     **92.106 ns** |     **264.270 ns** |       **400.0 ns** |     **496 B** |
 RemoveAt_Mid   | 1     | 1000000 |   426,496.00 ns |  8,173.083 ns |  10,910.831 ns |   423,300.0 ns |     496 B |
 RemoveAt_Last  | 1     | 1000000 |       261.76 ns |     74.067 ns |     200.245 ns |       150.0 ns |     496 B |
 **RemoveAt_First** | **5**     | **100**     |       **181.82 ns** |     **15.145 ns** |      **38.822 ns** |       **200.0 ns** |     **544 B** |
 RemoveAt_Mid   | 5     | 100     |       341.76 ns |     27.657 ns |      77.554 ns |       300.0 ns |     544 B |
 RemoveAt_Last  | 5     | 100     |        74.68 ns |     16.836 ns |      43.760 ns |       100.0 ns |     544 B |
 **RemoveAt_First** | **5**     | **10000**   |       **258.16 ns** |     **25.063 ns** |      **73.110 ns** |       **200.0 ns** |     **544 B** |
 RemoveAt_Mid   | 5     | 10000   |    20,506.67 ns |    237.221 ns |     221.897 ns |    20,500.0 ns |     544 B |
 RemoveAt_Last  | 5     | 10000   |       173.68 ns |     23.959 ns |      68.743 ns |       200.0 ns |     544 B |
 **RemoveAt_First** | **5**     | **1000000** |       **460.82 ns** |     **62.250 ns** |     **180.599 ns** |       **400.0 ns** |     **496 B** |
 RemoveAt_Mid   | 5     | 1000000 | 2,209,945.24 ns | 43,749.045 ns |  79,997.603 ns | 2,200,300.0 ns |     496 B |
 RemoveAt_Last  | 5     | 1000000 |       359.55 ns |     74.739 ns |     207.101 ns |       300.0 ns |    5888 B |
 **RemoveAt_First** | **10**    | **100**     |       **269.66 ns** |     **21.353 ns** |      **59.169 ns** |       **300.0 ns** |     **544 B** |
 RemoveAt_Mid   | 10    | 100     |       566.67 ns |     23.436 ns |      66.485 ns |       600.0 ns |     544 B |
 RemoveAt_Last  | 10    | 100     |       100.00 ns |      0.000 ns |       0.000 ns |       100.0 ns |     544 B |
 **RemoveAt_First** | **10**    | **10000**   |       **300.00 ns** |      **0.000 ns** |       **0.000 ns** |       **300.0 ns** |     **544 B** |
 RemoveAt_Mid   | 10    | 10000   |    40,746.15 ns |    186.904 ns |     156.074 ns |    40,700.0 ns |     544 B |
 RemoveAt_Last  | 10    | 10000   |       179.79 ns |     23.318 ns |      66.526 ns |       200.0 ns |     544 B |
 **RemoveAt_First** | **10**    | **1000000** |       **465.31 ns** |     **48.004 ns** |     **140.031 ns** |       **400.0 ns** |     **496 B** |
 RemoveAt_Mid   | 10    | 1000000 | 4,308,613.04 ns | 85,945.690 ns | 108,693.779 ns | 4,276,000.0 ns |     496 B |
 RemoveAt_Last  | 10    | 1000000 |       511.58 ns |    103.048 ns |     295.665 ns |       400.0 ns |     496 B |
