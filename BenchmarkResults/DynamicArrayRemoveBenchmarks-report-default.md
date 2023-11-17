
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-HRDTVF : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method     | Size    | Mean           | Error        | StdDev        | Median         | Allocated   |
----------- |-------- |---------------:|-------------:|--------------:|---------------:|------------:|
 **Remove_Min** | **100**     |       **622.3 ns** |     **43.36 ns** |     **123.70 ns** |       **600.0 ns** |     **2.85 KB** |
 Remove_Mid | 100     |       681.2 ns |     54.70 ns |     157.82 ns |       600.0 ns |     2.85 KB |
 Remove_Max | 100     |       550.0 ns |     22.75 ns |      61.11 ns |       500.0 ns |     2.88 KB |
 **Remove_Min** | **10000**   |    **24,531.2 ns** |    **463.95 ns** |     **455.66 ns** |    **24,400.0 ns** |   **234.88 KB** |
 Remove_Mid | 10000   |    22,264.3 ns |    411.77 ns |     365.02 ns |    22,300.0 ns |   234.88 KB |
 Remove_Max | 10000   |    20,035.7 ns |    292.18 ns |     259.01 ns |    20,000.0 ns |   234.91 KB |
 **Remove_Min** | **1000000** | **2,604,385.7 ns** | **70,541.62 ns** | **205,773.21 ns** | **2,506,050.0 ns** | **23437.96 KB** |
 Remove_Mid | 1000000 | 2,264,308.3 ns | 44,653.74 ns |  88,142.12 ns | 2,231,350.0 ns | 23438.01 KB |
 Remove_Max | 1000000 | 2,095,759.4 ns | 46,166.49 ns | 133,200.88 ns | 2,036,100.0 ns | 23438.03 KB |
