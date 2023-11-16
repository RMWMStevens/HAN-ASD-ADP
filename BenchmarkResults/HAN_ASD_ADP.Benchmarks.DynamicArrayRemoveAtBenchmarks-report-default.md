
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-QZSNDR : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                         | Mean        | Error     | StdDev    | Median     | Ratio | RatioSD |
------------------------------- |------------:|----------:|----------:|-----------:|------:|--------:|
 RemoveAt_Aflopend2_1           |    83.87 ns | 13.035 ns | 36.979 ns |   100.0 ns |     ? |       ? |
 RemoveAt_Aflopend2_1_Again     |    82.02 ns | 13.936 ns | 38.618 ns |   100.0 ns |     ? |       ? |
 RemoveAt_Float8001_0           | 3,300.00 ns |  0.000 ns |  0.000 ns | 3,300.0 ns |     ? |       ? |
 RemoveAt_Float8001_4000        | 1,687.50 ns | 34.778 ns | 34.157 ns | 1,700.0 ns |     ? |       ? |
 RemoveAt_Float8001_8000        |    72.22 ns | 16.158 ns | 45.041 ns |   100.0 ns |     ? |       ? |
 RemoveAt_Willekeurig10000_0    | 4,569.23 ns | 89.943 ns | 75.107 ns | 4,600.0 ns |     ? |       ? |
 RemoveAt_Willekeurig10000_2000 | 3,628.57 ns | 68.953 ns | 61.125 ns | 3,600.0 ns |     ? |       ? |
 RemoveAt_Willekeurig10000_4000 | 2,800.00 ns |  0.000 ns |  0.000 ns | 2,800.0 ns |     ? |       ? |
 RemoveAt_Willekeurig10000_6000 | 1,893.33 ns | 27.603 ns | 25.820 ns | 1,900.0 ns |     ? |       ? |
 RemoveAt_Willekeurig10000_8000 |   984.21 ns | 21.423 ns | 36.954 ns | 1,000.0 ns |     ? |       ? |
