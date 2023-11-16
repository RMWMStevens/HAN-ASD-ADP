
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2


 Method                 | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD |
----------------------- |----------:|----------:|----------:|----------:|------:|--------:|
 Count_Aflopend2        | 0.0011 ns | 0.0021 ns | 0.0019 ns | 0.0000 ns |     ? |       ? |
 Count_Float8001        | 0.0022 ns | 0.0018 ns | 0.0015 ns | 0.0021 ns |     ? |       ? |
 Count_Willekeurig10000 | 0.0006 ns | 0.0010 ns | 0.0009 ns | 0.0000 ns |     ? |       ? |
