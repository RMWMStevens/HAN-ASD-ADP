
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-HRDTVF : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method     | Size    | Mean           | Error        | StdDev       | Median         | Allocated  |
----------- |-------- |---------------:|-------------:|-------------:|---------------:|-----------:|
 **Remove_Min** | **100**     |       **412.8 ns** |     **25.71 ns** |     **69.95 ns** |       **400.0 ns** |      **568 B** |
 Remove_Mid | 100     |       532.9 ns |     24.47 ns |     66.17 ns |       500.0 ns |     1768 B |
 Remove_Max | 100     |       619.3 ns |     31.07 ns |     85.58 ns |       600.0 ns |     2944 B |
 **Remove_Min** | **10000**   |       **480.2 ns** |     **57.03 ns** |    **164.55 ns** |       **400.0 ns** |      **568 B** |
 Remove_Mid | 10000   |     9,681.5 ns |    193.88 ns |    271.80 ns |     9,600.0 ns |   120568 B |
 Remove_Max | 10000   |    18,981.2 ns |    226.82 ns |    222.77 ns |    19,000.0 ns |   240544 B |
 **Remove_Min** | **1000000** |     **1,260.4 ns** |    **117.88 ns** |    **340.12 ns** |     **1,200.0 ns** |      **520 B** |
 Remove_Mid | 1000000 | 1,033,090.9 ns | 20,636.83 ns | 32,732.19 ns | 1,033,000.0 ns | 12000520 B |
 Remove_Max | 1000000 | 2,107,728.6 ns | 37,313.27 ns | 33,077.24 ns | 2,111,800.0 ns | 24000496 B |
