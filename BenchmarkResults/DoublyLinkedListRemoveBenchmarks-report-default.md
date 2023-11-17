
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-GFXNRG : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method     | Size    | Mean           | Error        | StdDev        | Median         | Allocated  |
----------- |-------- |---------------:|-------------:|--------------:|---------------:|-----------:|
 **Remove_Min** | **10**      |       **425.3 ns** |     **26.84 ns** |      **73.48 ns** |       **400.0 ns** |      **568 B** |
 Remove_Mid | 10      |       506.4 ns |     51.09 ns |     145.77 ns |       400.0 ns |      688 B |
 Remove_Max | 10      |       644.0 ns |     69.58 ns |     205.15 ns |       600.0 ns |      784 B |
 **Remove_Min** | **100**     |       **511.1 ns** |     **73.37 ns** |     **215.18 ns** |       **400.0 ns** |      **568 B** |
 Remove_Mid | 100     |       585.4 ns |     50.61 ns |     140.25 ns |       500.0 ns |     1768 B |
 Remove_Max | 100     |       541.2 ns |     24.09 ns |      63.03 ns |       500.0 ns |     2944 B |
 **Remove_Min** | **1000**    |       **403.2 ns** |     **58.71 ns** |     **167.49 ns** |       **300.0 ns** |      **568 B** |
 Remove_Mid | 1000    |     1,474.2 ns |     93.91 ns |     272.44 ns |     1,300.0 ns |    12568 B |
 Remove_Max | 1000    |     2,393.7 ns |    101.27 ns |     290.56 ns |     2,300.0 ns |    24544 B |
 **Remove_Min** | **10000**   |       **496.7 ns** |     **46.40 ns** |     **129.35 ns** |       **500.0 ns** |      **568 B** |
 Remove_Mid | 10000   |    10,050.0 ns |    201.84 ns |     358.77 ns |    10,100.0 ns |   120568 B |
 Remove_Max | 10000   |    19,522.0 ns |    386.31 ns |     696.60 ns |    19,400.0 ns |   240544 B |
 **Remove_Min** | **100000**  |       **768.8 ns** |     **70.64 ns** |     **203.81 ns** |       **800.0 ns** |      **568 B** |
 Remove_Mid | 100000  |    94,083.3 ns |  1,686.75 ns |   1,316.91 ns |    93,650.0 ns |  1200568 B |
 Remove_Max | 100000  |   202,931.9 ns |  5,998.83 ns |  17,115.01 ns |   195,300.0 ns |  2400544 B |
 **Remove_Min** | **1000000** |     **1,539.6 ns** |    **167.05 ns** |     **481.99 ns** |     **1,400.0 ns** |      **520 B** |
 Remove_Mid | 1000000 | 1,045,744.9 ns | 20,622.30 ns |  41,184.95 ns | 1,039,300.0 ns | 12000520 B |
 Remove_Max | 1000000 | 2,313,820.9 ns | 51,897.11 ns | 145,525.06 ns | 2,289,200.0 ns | 24000496 B |
