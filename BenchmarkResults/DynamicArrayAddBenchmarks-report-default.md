
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-QZSNDR : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                  | Mean      | Error     | StdDev     | Median   | Ratio | RatioSD |
------------------------ |----------:|----------:|-----------:|---------:|------:|--------:|
 Add_Oplopend2_1x        |  74.00 ns | 21.352 ns |  62.957 ns | 100.0 ns |     ? |       ? |
 Add_Oplopend2_2x        | 148.00 ns | 20.154 ns |  59.425 ns | 100.0 ns |     ? |       ? |
 Add_Oplopend2_3x        | 475.84 ns | 28.545 ns |  79.097 ns | 450.0 ns |     ? |       ? |
 Add_Oplopend2_4x        | 472.53 ns | 24.400 ns |  68.420 ns | 500.0 ns |     ? |       ? |
 Add_Float8001           |  74.67 ns | 17.326 ns |  43.785 ns | 100.0 ns |     ? |       ? |
 Add_GesorteerdAflopend3 |  84.44 ns | 13.074 ns |  36.446 ns | 100.0 ns |     ? |       ? |
 Add_Leeg0_1x            | 100.00 ns |  0.000 ns |   0.000 ns | 100.0 ns |     ? |       ? |
 Add_Leeg0_2x            | 100.00 ns |  0.000 ns |   0.000 ns | 100.0 ns |     ? |       ? |
 Add_Leeg0_3x            | 223.00 ns | 27.207 ns |  80.221 ns | 200.0 ns |     ? |       ? |
 Add_Leeg0_4x            | 216.00 ns | 23.967 ns |  70.668 ns | 200.0 ns |     ? |       ? |
 Add_Leeg0_5x            | 725.25 ns | 68.427 ns | 200.684 ns | 700.0 ns |     ? |       ? |
 Add_Leeg0_6x            | 779.00 ns | 67.020 ns | 197.609 ns | 700.0 ns |     ? |       ? |
 Add_Null3_1x            | 157.00 ns | 22.741 ns |  67.052 ns | 100.0 ns |     ? |       ? |
 Add_Null3_2x            | 722.00 ns | 55.085 ns | 162.419 ns | 700.0 ns |     ? |       ? |
 Add_Onsorteerbaar3      | 463.04 ns | 21.491 ns |  60.615 ns | 500.0 ns |     ? |       ? |
 Add_Willekeurig10000    |  90.80 ns | 10.617 ns |  29.064 ns | 100.0 ns |     ? |       ? |
