
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-FJSBUM : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method       | Length | Times | Mean        | Error       | StdDev      | Median      | Allocated |
------------- |------- |------ |------------:|------------:|------------:|------------:|----------:|
 **EnqueueLeft**  | **1**      | **1**     |    **423.2 ns** |    **40.70 ns** |   **119.38 ns** |    **400.0 ns** |     **592 B** |
 EnqueueRight | 1      | 1     |    429.2 ns |    33.63 ns |    93.18 ns |    400.0 ns |     592 B |
 **EnqueueLeft**  | **1**      | **100**   |  **1,345.7 ns** |    **74.60 ns** |   **212.85 ns** |  **1,300.0 ns** |    **5344 B** |
 EnqueueRight | 1      | 100   |  1,109.3 ns |    27.98 ns |    76.12 ns |  1,100.0 ns |    5344 B |
 **EnqueueLeft**  | **1**      | **10000** | **86,066.7 ns** |   **387.47 ns** |   **302.51 ns** | **86,100.0 ns** |  **480544 B** |
 EnqueueRight | 1      | 10000 | 77,412.5 ns | 1,453.73 ns | 1,427.76 ns | 77,100.0 ns |  480544 B |
 **EnqueueLeft**  | **100**    | **1**     |    **413.3 ns** |    **32.80 ns** |    **91.43 ns** |    **400.0 ns** |     **592 B** |
 EnqueueRight | 100    | 1     |    411.5 ns |    32.69 ns |    89.48 ns |    400.0 ns |     592 B |
 **EnqueueLeft**  | **100**    | **100**   |  **1,232.6 ns** |    **28.99 ns** |    **78.88 ns** |  **1,200.0 ns** |    **5344 B** |
 EnqueueRight | 100    | 100   |  1,107.2 ns |    33.50 ns |    89.42 ns |  1,100.0 ns |    5344 B |
 **EnqueueLeft**  | **100**    | **10000** | **87,200.0 ns** | **1,647.78 ns** | **1,541.34 ns** | **86,200.0 ns** |  **480544 B** |
 EnqueueRight | 100    | 10000 | 77,592.3 ns |   724.26 ns |   604.79 ns | 77,700.0 ns |  480544 B |
 **EnqueueLeft**  | **10000**  | **1**     |    **437.1 ns** |    **46.76 ns** |   **135.65 ns** |    **400.0 ns** |     **592 B** |
 EnqueueRight | 10000  | 1     |    480.6 ns |    50.60 ns |   147.60 ns |    400.0 ns |     592 B |
 **EnqueueLeft**  | **10000**  | **100**   |  **1,318.4 ns** |    **48.41 ns** |   **132.53 ns** |  **1,300.0 ns** |    **5344 B** |
 EnqueueRight | 10000  | 100   |  1,338.8 ns |    77.93 ns |   227.33 ns |  1,250.0 ns |    5344 B |
 **EnqueueLeft**  | **10000**  | **10000** | **86,628.6 ns** | **1,345.28 ns** | **1,192.56 ns** | **86,000.0 ns** |  **480544 B** |
 EnqueueRight | 10000  | 10000 | 76,766.7 ns |   821.66 ns |   641.49 ns | 76,700.0 ns |  480544 B |
