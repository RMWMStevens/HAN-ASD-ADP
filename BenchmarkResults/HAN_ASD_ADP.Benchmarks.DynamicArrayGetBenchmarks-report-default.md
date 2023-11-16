
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2


 Method                    | Mean      | Error     | StdDev    | Ratio | RatioSD |
-------------------------- |----------:|----------:|----------:|------:|--------:|
 Get_GesorteerdOplopend3_0 | 0.0226 ns | 0.0063 ns | 0.0059 ns |  1.00 |    0.00 |
 Get_GesorteerdOplopend3_1 | 0.2133 ns | 0.0050 ns | 0.0046 ns | 10.16 |    3.09 |
 Get_GesorteerdOplopend3_2 | 0.0205 ns | 0.0055 ns | 0.0046 ns |  0.97 |    0.35 |
 Get_Float8001_0           | 0.0168 ns | 0.0041 ns | 0.0039 ns |  0.80 |    0.28 |
 Get_Float8001_1           | 0.2204 ns | 0.0054 ns | 0.0050 ns | 10.51 |    3.21 |
 Get_Float8001_2           | 0.0181 ns | 0.0067 ns | 0.0060 ns |  0.85 |    0.29 |
 Get_Float8001_4000        | 0.0215 ns | 0.0125 ns | 0.0111 ns |  1.01 |    0.51 |
 Get_Float8001_8000        | 0.0157 ns | 0.0017 ns | 0.0015 ns |  0.75 |    0.26 |
 Get_Oplopend10000_0       | 0.2138 ns | 0.0049 ns | 0.0043 ns | 10.31 |    3.31 |
 Get_Oplopend10000_1       | 0.0150 ns | 0.0019 ns | 0.0017 ns |  0.72 |    0.26 |
 Get_Oplopend10000_2       | 0.0143 ns | 0.0057 ns | 0.0054 ns |  0.67 |    0.31 |
 Get_Oplopend10000_4000    | 0.0130 ns | 0.0014 ns | 0.0011 ns |  0.64 |    0.21 |
 Get_Oplopend10000_8000    | 0.2109 ns | 0.0028 ns | 0.0025 ns | 10.17 |    3.28 |
