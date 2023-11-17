
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2
  Job-VWFLJL : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method         | ArraySize | Mean          | Error      | StdDev     | Median        |
--------------- |---------- |--------------:|-----------:|-----------:|--------------:|
 **RemoveAt_First** | **10**        |    **57.0000 ns** | **20.0240 ns** | **59.0412 ns** |   **100.0000 ns** |
 RemoveAt_Mid   | 10        |     0.0000 ns |  0.0000 ns |  0.0000 ns |     0.0000 ns |
 RemoveAt_Last  | 10        |     0.0000 ns |  0.0000 ns |  0.0000 ns |     0.0000 ns |
 **RemoveAt_First** | **100**       |    **88.1579 ns** | **12.7785 ns** | **32.5253 ns** |   **100.0000 ns** |
 RemoveAt_Mid   | 100       |   100.0000 ns |  0.0000 ns |  0.0000 ns |   100.0000 ns |
 RemoveAt_Last  | 100       |    24.0000 ns | 10.3613 ns | 30.5505 ns |     0.0000 ns |
 **RemoveAt_First** | **1000**      |   **530.8511 ns** | **30.8514 ns** | **88.0208 ns** |   **500.0000 ns** |
 RemoveAt_Mid   | 1000      |   289.6907 ns | 24.6179 ns | 71.4209 ns |   300.0000 ns |
 RemoveAt_Last  | 1000      |    60.0000 ns | 21.0121 ns | 61.9547 ns |   100.0000 ns |
 **RemoveAt_First** | **10000**     | **4,538.4615 ns** | **91.9648 ns** | **76.7948 ns** | **4,600.0000 ns** |
 RemoveAt_Mid   | 10000     | 2,286.6667 ns | 37.6166 ns | 35.1866 ns | 2,300.0000 ns |
 RemoveAt_Last  | 10000     |    49.0000 ns | 21.2841 ns | 62.7565 ns |     0.0000 ns |
