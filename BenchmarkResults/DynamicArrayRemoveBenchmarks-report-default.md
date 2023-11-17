
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2
  Job-VWFLJL : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method     | ArraySize | Mean        | Error     | StdDev    | Median      |
----------- |---------- |------------:|----------:|----------:|------------:|
 **Remove_Min** | **10**        |    **424.2 ns** |  **40.19 ns** | **117.88 ns** |    **400.0 ns** |
 Remove_Mid | 10        |    447.5 ns |  48.30 ns | 141.67 ns |    400.0 ns |
 Remove_Max | 10        |    347.6 ns |  26.78 ns |  71.94 ns |    300.0 ns |
 **Remove_Min** | **100**       |    **597.0 ns** |  **50.96 ns** | **149.46 ns** |    **500.0 ns** |
 Remove_Mid | 100       |    552.9 ns |  25.90 ns |  70.01 ns |    500.0 ns |
 Remove_Max | 100       |    592.9 ns |  45.45 ns | 132.58 ns |    550.0 ns |
 **Remove_Min** | **1000**      |  **3,155.1 ns** | **140.02 ns** | **408.45 ns** |  **3,050.0 ns** |
 Remove_Mid | 1000      |  2,833.0 ns | 130.25 ns | 384.04 ns |  2,700.0 ns |
 Remove_Max | 1000      |  2,461.2 ns | 129.55 ns | 377.90 ns |  2,300.0 ns |
 **Remove_Min** | **10000**     | **24,593.3 ns** | **473.75 ns** | **443.15 ns** | **24,600.0 ns** |
 Remove_Mid | 10000     | 22,528.6 ns | 376.56 ns | 333.81 ns | 22,500.0 ns |
 Remove_Max | 10000     | 20,188.0 ns | 344.67 ns | 696.24 ns | 19,950.0 ns |
