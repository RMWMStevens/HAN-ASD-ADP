
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WBRHZI : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method     | Size    | Mean           | Error        | StdDev       | Median         | Allocated  |
----------- |-------- |---------------:|-------------:|-------------:|---------------:|-----------:|
 **Remove_Min** | **1**       |       **355.6 ns** |     **23.51 ns** |     **65.53 ns** |       **300.0 ns** |      **568 B** |
 Remove_Mid | 1       |       362.1 ns |     25.67 ns |     70.28 ns |       400.0 ns |      568 B |
 Remove_Max | 1       |       376.1 ns |     23.99 ns |     66.08 ns |       400.0 ns |      568 B |
 **Remove_Min** | **10**      |       **405.7 ns** |     **31.19 ns** |     **85.39 ns** |       **400.0 ns** |      **760 B** |
 Remove_Mid | 10      |       478.1 ns |     51.09 ns |    147.40 ns |       400.0 ns |      760 B |
 Remove_Max | 10      |       410.6 ns |     34.26 ns |     92.61 ns |       400.0 ns |      784 B |
 **Remove_Min** | **100**     |       **634.7 ns** |     **46.53 ns** |    **133.50 ns** |       **600.0 ns** |     **2920 B** |
 Remove_Mid | 100     |       666.3 ns |     54.13 ns |    157.91 ns |       600.0 ns |     2920 B |
 Remove_Max | 100     |       555.1 ns |     24.34 ns |     67.44 ns |       500.0 ns |     2944 B |
 **Remove_Min** | **1000**    |     **2,711.8 ns** |     **54.47 ns** |     **87.96 ns** |     **2,700.0 ns** |    **24520 B** |
 Remove_Mid | 1000    |     2,539.4 ns |     52.56 ns |    123.88 ns |     2,500.0 ns |    24520 B |
 Remove_Max | 1000    |     2,274.4 ns |     46.71 ns |     81.81 ns |     2,300.0 ns |    24544 B |
 **Remove_Min** | **10000**   |    **24,726.3 ns** |    **278.41 ns** |    **480.25 ns** |    **24,700.0 ns** |   **240520 B** |
 Remove_Mid | 10000   |    22,250.0 ns |    347.69 ns |    308.22 ns |    22,200.0 ns |   240520 B |
 Remove_Max | 10000   |    20,016.7 ns |    394.54 ns |    513.02 ns |    19,900.0 ns |   240544 B |
 **Remove_Min** | **100000**  |   **242,818.8 ns** |  **2,846.86 ns** |  **2,796.00 ns** |   **242,400.0 ns** |  **2400520 B** |
 Remove_Mid | 100000  |   218,114.3 ns |  3,997.59 ns |  3,543.76 ns |   217,750.0 ns |  2400520 B |
 Remove_Max | 100000  |   198,105.6 ns |  3,949.25 ns |  6,598.31 ns |   197,300.0 ns |  2400544 B |
 **Remove_Min** | **1000000** | **2,458,473.3 ns** | **41,039.27 ns** | **38,388.16 ns** | **2,459,300.0 ns** | **24000520 B** |
 Remove_Mid | 1000000 | 2,207,741.7 ns | 38,127.42 ns | 29,767.38 ns | 2,202,250.0 ns | 24000520 B |
 Remove_Max | 1000000 | 1,969,168.8 ns | 38,383.36 ns | 59,758.26 ns | 1,952,300.0 ns | 24000544 B |
