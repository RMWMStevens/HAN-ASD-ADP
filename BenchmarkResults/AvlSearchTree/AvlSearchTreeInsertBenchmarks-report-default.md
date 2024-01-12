
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-EXFOWV : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                           | Length | Times | Mean       | Error     | StdDev   | Median   |
--------------------------------- |------- |------ |-----------:|----------:|---------:|---------:|
 Insert_EmptyTree_SlideValuesMin2 | 10000  | 1     |   904.0 ns | 110.75 ns | 324.8 ns | 800.0 ns |
 Insert_EmptyTree_SlideValuesMin1 | 10000  | 1     | 1,106.1 ns | 125.03 ns | 366.7 ns | 900.0 ns |
 Insert_EmptyTree_SlideValues     | 10000  | 1     | 1,067.0 ns | 107.25 ns | 311.2 ns | 900.0 ns |
 Insert_49_FilledTree             | 10000  | 1     |   598.0 ns |  88.33 ns | 257.7 ns | 500.0 ns |
 Insert_513_FilledTree            | 10000  | 1     |   497.0 ns |  61.89 ns | 181.5 ns | 400.0 ns |
 Insert_6549_FilledTree           | 10000  | 1     |   610.3 ns |  83.32 ns | 241.7 ns | 500.0 ns |
 Insert_9413_FilledTree           | 10000  | 1     |   528.6 ns |  69.31 ns | 202.2 ns | 450.0 ns |
