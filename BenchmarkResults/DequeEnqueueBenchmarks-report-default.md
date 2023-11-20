
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-ZZBLTY : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method       | Length | Times | Mean        | Error       | StdDev      | Median      | Allocated |
------------- |------- |------ |------------:|------------:|------------:|------------:|----------:|
 **EnqueueLeft**  | **1**      | **1**     |    **345.3 ns** |    **25.63 ns** |    **69.72 ns** |    **300.0 ns** |     **592 B** |
 EnqueueRight | 1      | 1     |    414.1 ns |    48.96 ns |   143.58 ns |    400.0 ns |     592 B |
 **EnqueueLeft**  | **1**      | **100**   |  **1,388.0 ns** |    **86.13 ns** |   **253.97 ns** |  **1,300.0 ns** |    **5344 B** |
 EnqueueRight | 1      | 100   |  1,167.4 ns |    55.90 ns |   157.67 ns |  1,100.0 ns |    5344 B |
 **EnqueueLeft**  | **1**      | **10000** | **86,412.5 ns** | **1,684.95 ns** | **1,654.84 ns** | **85,850.0 ns** |  **480544 B** |
 EnqueueRight | 1      | 10000 | 75,307.7 ns |   529.86 ns |   442.46 ns | 75,400.0 ns |  480544 B |
 **EnqueueLeft**  | **100**    | **1**     |    **438.5 ns** |    **40.41 ns** |   **113.30 ns** |    **400.0 ns** |     **592 B** |
 EnqueueRight | 100    | 1     |    403.0 ns |    48.55 ns |   143.16 ns |    400.0 ns |     592 B |
 **EnqueueLeft**  | **100**    | **100**   |  **1,203.5 ns** |    **27.64 ns** |    **74.72 ns** |  **1,200.0 ns** |    **5344 B** |
 EnqueueRight | 100    | 100   |  1,100.0 ns |    30.36 ns |    82.60 ns |  1,100.0 ns |    5344 B |
 **EnqueueLeft**  | **100**    | **10000** | **87,176.9 ns** |   **584.95 ns** |   **488.46 ns** | **87,100.0 ns** |  **480544 B** |
 EnqueueRight | 100    | 10000 | 76,738.5 ns |   827.57 ns |   691.06 ns | 76,500.0 ns |  480544 B |
 **EnqueueLeft**  | **10000**  | **1**     |    **480.0 ns** |    **55.17 ns** |   **162.68 ns** |    **400.0 ns** |     **592 B** |
 EnqueueRight | 10000  | 1     |    406.7 ns |    28.35 ns |    79.04 ns |    400.0 ns |     592 B |
 **EnqueueLeft**  | **10000**  | **100**   |  **1,253.0 ns** |    **27.06 ns** |    **63.78 ns** |  **1,200.0 ns** |    **5344 B** |
 EnqueueRight | 10000  | 100   |  1,105.6 ns |    47.91 ns |   133.54 ns |  1,100.0 ns |    5344 B |
 **EnqueueLeft**  | **10000**  | **10000** | **87,741.7 ns** | **1,034.03 ns** |   **807.31 ns** | **87,450.0 ns** |  **480544 B** |
 EnqueueRight | 10000  | 10000 | 77,696.2 ns |   884.90 ns |   738.94 ns | 77,750.0 ns |  480544 B |
