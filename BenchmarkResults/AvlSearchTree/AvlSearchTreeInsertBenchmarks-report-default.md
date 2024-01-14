
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-NNKNHT : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                           | Length | Times | Mean     | Error     | StdDev    | Median   |
--------------------------------- |------- |------ |---------:|----------:|----------:|---------:|
 Insert_EmptyTree_SlideValuesMin2 | 10000  | 1     | 1.468 μs | 0.1339 μs | 0.3885 μs | 1.300 μs |
 Insert_EmptyTree_SlideValuesMin1 | 10000  | 1     | 1.432 μs | 0.1208 μs | 0.3465 μs | 1.300 μs |
 Insert_EmptyTree_SlideValues     | 10000  | 1     | 1.570 μs | 0.1182 μs | 0.3428 μs | 1.400 μs |
 Insert_49_FilledTree             | 10000  | 1     | 9.289 μs | 0.5007 μs | 1.4447 μs | 8.800 μs |
 Insert_513_FilledTree            | 10000  | 1     | 7.425 μs | 0.1990 μs | 0.5581 μs | 7.300 μs |
 Insert_6549_FilledTree           | 10000  | 1     | 2.609 μs | 0.1455 μs | 0.4245 μs | 2.550 μs |
 Insert_9413_FilledTree           | 10000  | 1     | 1.611 μs | 0.1338 μs | 0.3903 μs | 1.400 μs |
