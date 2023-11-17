
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-GFXNRG : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method         | Size    | Mean            | Error         | StdDev        | Median          | Allocated |
--------------- |-------- |----------------:|--------------:|--------------:|----------------:|----------:|
 **RemoveAt_First** | **1**       |      **42.8571 ns** |    **20.2960 ns** |    **59.2043 ns** |       **0.0000 ns** |     **544 B** |
 RemoveAt_Mid   | 1       |      88.0000 ns |    22.7536 ns |    67.0896 ns |     100.0000 ns |     544 B |
 RemoveAt_Last  | 1       |      75.0000 ns |    20.0935 ns |    59.2461 ns |     100.0000 ns |     544 B |
 **RemoveAt_First** | **10**      |       **0.0000 ns** |     **0.0000 ns** |     **0.0000 ns** |       **0.0000 ns** |     **544 B** |
 RemoveAt_Mid   | 10      |      68.0000 ns |    19.8052 ns |    58.3961 ns |     100.0000 ns |     544 B |
 RemoveAt_Last  | 10      |      59.0000 ns |    20.5056 ns |    60.4612 ns |     100.0000 ns |     544 B |
 **RemoveAt_First** | **100**     |      **93.0000 ns** |    **22.7409 ns** |    **67.0519 ns** |     **100.0000 ns** |     **544 B** |
 RemoveAt_Mid   | 100     |      76.0000 ns |    18.1138 ns |    53.4090 ns |     100.0000 ns |     544 B |
 RemoveAt_Last  | 100     |      48.0000 ns |    21.8151 ns |    64.3224 ns |       0.0000 ns |     544 B |
 **RemoveAt_First** | **1000**    |     **470.2128 ns** |    **21.0864 ns** |    **60.1607 ns** |     **500.0000 ns** |     **544 B** |
 RemoveAt_Mid   | 1000    |     331.9588 ns |    21.9957 ns |    63.8135 ns |     300.0000 ns |     544 B |
 RemoveAt_Last  | 1000    |      73.0000 ns |    19.1945 ns |    56.5953 ns |     100.0000 ns |     544 B |
 **RemoveAt_First** | **10000**   |   **4,568.7500 ns** |    **88.9097 ns** |    **87.3212 ns** |   **4,600.0000 ns** |     **544 B** |
 RemoveAt_Mid   | 10000   |   2,308.6957 ns |    47.1607 ns |    59.6432 ns |   2,300.0000 ns |     544 B |
 RemoveAt_Last  | 10000   |      58.0000 ns |    19.9804 ns |    58.9127 ns |     100.0000 ns |     544 B |
 **RemoveAt_First** | **100000**  |  **45,446.1538 ns** |   **756.7836 ns** |   **631.9486 ns** |  **45,200.0000 ns** |     **544 B** |
 RemoveAt_Mid   | 100000  |  22,366.6667 ns |   431.1969 ns |   336.6502 ns |  22,200.0000 ns |     544 B |
 RemoveAt_Last  | 100000  |      79.1209 ns |    14.5749 ns |    40.8697 ns |     100.0000 ns |     544 B |
 **RemoveAt_First** | **1000000** | **456,057.1429 ns** | **4,733.8857 ns** | **4,196.4663 ns** | **455,300.0000 ns** |     **544 B** |
 RemoveAt_Mid   | 1000000 | 231,184.6154 ns | 3,621.7236 ns | 3,024.3033 ns | 231,500.0000 ns |     544 B |
 RemoveAt_Last  | 1000000 |     113.2653 ns |    23.9325 ns |    69.8123 ns |     100.0000 ns |     544 B |
