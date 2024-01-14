
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-LNRJDX : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method               | Times | Mean     | Error     | StdDev    | Median   | Allocated |
--------------------- |------ |---------:|----------:|----------:|---------:|----------:|
 **Add_SeparateChaining** | **1**     | **1.914 μs** | **0.1323 μs** | **0.3643 μs** | **1.800 μs** |     **672 B** |
 Add_LinearProbing    | 1     | 1.300 μs | 0.0674 μs | 0.1834 μs | 1.300 μs |     584 B |
 Add_QuadraticProbing | 1     | 1.315 μs | 0.0695 μs | 0.1961 μs | 1.300 μs |     584 B |
 **Add_SeparateChaining** | **5**     | **2.685 μs** | **0.2138 μs** | **0.6168 μs** | **2.400 μs** |    **1096 B** |
 Add_LinearProbing    | 5     | 1.722 μs | 0.1315 μs | 0.3795 μs | 1.600 μs |     744 B |
 Add_QuadraticProbing | 5     | 1.645 μs | 0.0734 μs | 0.2010 μs | 1.600 μs |     744 B |
 **Add_SeparateChaining** | **10**    | **3.281 μs** | **0.1727 μs** | **0.4956 μs** | **3.100 μs** |    **1560 B** |
 Add_LinearProbing    | 10    | 1.959 μs | 0.1503 μs | 0.4264 μs | 1.800 μs |     944 B |
 Add_QuadraticProbing | 10    | 2.237 μs | 0.1633 μs | 0.4553 μs | 2.100 μs |     944 B |
