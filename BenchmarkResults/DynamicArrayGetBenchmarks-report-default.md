
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2
  Job-VWFLJL : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method    | ArraySize | Mean       | Error      | StdDev     | Median      |
---------- |---------- |-----------:|-----------:|-----------:|------------:|
 **Get_First** | **1**         | **39.0000 ns** | **17.9689 ns** | **52.9818 ns** |   **0.0000 ns** |
 Get_Mid   | 1         | 59.0000 ns | 18.7288 ns | 55.2222 ns | 100.0000 ns |
 Get_Last  | 1         |  0.0000 ns |  0.0000 ns |  0.0000 ns |   0.0000 ns |
 **Get_First** | **10**        | **62.0000 ns** | **17.8944 ns** | **52.7621 ns** | **100.0000 ns** |
 Get_Mid   | 10        |  0.0000 ns |  0.0000 ns |  0.0000 ns |   0.0000 ns |
 Get_Last  | 10        | 41.0000 ns | 17.4440 ns | 51.4340 ns |   0.0000 ns |
 **Get_First** | **100**       | **46.0000 ns** | **16.9884 ns** | **50.0908 ns** |   **0.0000 ns** |
 Get_Mid   | 100       | 31.3131 ns | 15.8935 ns | 46.6127 ns |   0.0000 ns |
 Get_Last  | 100       |  0.0000 ns |  0.0000 ns |  0.0000 ns |   0.0000 ns |
 **Get_First** | **1000**      | **39.0000 ns** | **18.6043 ns** | **54.8552 ns** |   **0.0000 ns** |
 Get_Mid   | 1000      | 49.0000 ns | 18.3528 ns | 54.1136 ns |   0.0000 ns |
 Get_Last  | 1000      | 48.0000 ns | 17.0294 ns | 50.2117 ns |   0.0000 ns |
 **Get_First** | **10000**     | **40.0000 ns** | **19.8755 ns** | **58.6033 ns** |   **0.0000 ns** |
 Get_Mid   | 10000     | 58.5859 ns | 17.5694 ns | 51.5279 ns | 100.0000 ns |
 Get_Last  | 10000     |  0.0000 ns |  0.0000 ns |  0.0000 ns |   0.0000 ns |
