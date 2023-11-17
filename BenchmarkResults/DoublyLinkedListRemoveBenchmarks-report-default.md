
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WBRHZI : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method     | Size    | Mean           | Error        | StdDev       | Median         | Allocated  |
----------- |-------- |---------------:|-------------:|-------------:|---------------:|-----------:|
 **Remove_Min** | **1**       |       **441.9 ns** |     **31.63 ns** |     **86.04 ns** |       **400.0 ns** |      **568 B** |
 Remove_Mid | 1       |       480.4 ns |     46.58 ns |    135.12 ns |       400.0 ns |      568 B |
 Remove_Max | 1       |       415.5 ns |     30.30 ns |     81.39 ns |       400.0 ns |      904 B |
 **Remove_Min** | **10**      |       **439.8 ns** |     **24.08 ns** |     **64.28 ns** |       **400.0 ns** |      **568 B** |
 Remove_Mid | 10      |       434.5 ns |     28.60 ns |     76.83 ns |       400.0 ns |      688 B |
 Remove_Max | 10      |       501.1 ns |     50.20 ns |    144.03 ns |       400.0 ns |      784 B |
 **Remove_Min** | **100**     |       **449.4 ns** |     **24.39 ns** |     **65.10 ns** |       **400.0 ns** |      **568 B** |
 Remove_Mid | 100     |       559.1 ns |     56.28 ns |    159.64 ns |       500.0 ns |     1768 B |
 Remove_Max | 100     |       667.4 ns |     59.38 ns |    170.38 ns |       600.0 ns |     2944 B |
 **Remove_Min** | **1000**    |       **351.9 ns** |     **23.33 ns** |     **61.46 ns** |       **400.0 ns** |      **568 B** |
 Remove_Mid | 1000    |     1,337.5 ns |     28.35 ns |     70.09 ns |     1,300.0 ns |    12568 B |
 Remove_Max | 1000    |     2,153.8 ns |     42.50 ns |     58.18 ns |     2,150.0 ns |    24544 B |
 **Remove_Min** | **10000**   |       **491.4 ns** |     **52.14 ns** |    **147.92 ns** |       **400.0 ns** |      **568 B** |
 Remove_Mid | 10000   |     9,863.6 ns |    198.73 ns |    244.06 ns |     9,900.0 ns |   120568 B |
 Remove_Max | 10000   |    19,119.6 ns |    382.60 ns |    737.15 ns |    18,900.0 ns |   240544 B |
 **Remove_Min** | **100000**  |       **615.6 ns** |     **48.07 ns** |    **134.01 ns** |       **600.0 ns** |      **568 B** |
 Remove_Mid | 100000  |    94,520.0 ns |  1,787.60 ns |  1,672.12 ns |    94,500.0 ns |  1200568 B |
 Remove_Max | 100000  |   187,976.9 ns |  1,950.16 ns |  1,628.47 ns |   187,500.0 ns |  2400544 B |
 **Remove_Min** | **1000000** |     **1,170.1 ns** |    **145.40 ns** |    **421.84 ns** |     **1,000.0 ns** |      **520 B** |
 Remove_Mid | 1000000 | 1,051,931.4 ns | 20,995.07 ns | 42,887.37 ns | 1,039,800.0 ns | 12000520 B |
 Remove_Max | 1000000 | 2,099,134.5 ns | 41,358.05 ns | 60,622.09 ns | 2,099,400.0 ns | 24000496 B |
