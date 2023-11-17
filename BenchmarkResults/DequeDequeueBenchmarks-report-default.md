
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-GGXILR : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                 | Times   | Mean           | Error         | StdDev        | Median         | Allocated |
----------------------- |-------- |---------------:|--------------:|--------------:|---------------:|----------:|
 **DequeueLeft**            | **1**       |       **158.0 ns** |      **20.55 ns** |      **60.60 ns** |       **200.0 ns** |     **544 B** |
 DequeueRight           | 1       |       148.0 ns |      23.85 ns |      70.32 ns |       100.0 ns |     544 B |
 DequeueLeft_Prefilled  | 1       |       160.2 ns |      22.95 ns |      66.95 ns |       150.0 ns |     544 B |
 DequeueRight_Prefilled | 1       |       164.6 ns |      24.51 ns |      71.87 ns |       200.0 ns |     544 B |
 **DequeueLeft**            | **100**     |     **1,474.1 ns** |      **31.42 ns** |      **68.98 ns** |     **1,500.0 ns** |     **544 B** |
 DequeueRight           | 100     |     1,250.8 ns |      26.93 ns |      61.89 ns |     1,200.0 ns |     544 B |
 DequeueLeft_Prefilled  | 100     |     1,422.2 ns |      52.63 ns |     146.71 ns |     1,400.0 ns |     544 B |
 DequeueRight_Prefilled | 100     |     1,309.8 ns |      31.14 ns |      82.57 ns |     1,300.0 ns |     544 B |
 **DequeueLeft**            | **10000**   |   **113,650.0 ns** |   **1,268.56 ns** |     **990.41 ns** |   **113,650.0 ns** |     **544 B** |
 DequeueRight           | 10000   |   103,576.9 ns |   1,863.03 ns |   1,555.72 ns |   103,100.0 ns |     544 B |
 DequeueLeft_Prefilled  | 10000   |   115,715.4 ns |   1,882.62 ns |   1,572.07 ns |   115,600.0 ns |     544 B |
 DequeueRight_Prefilled | 10000   |   104,092.3 ns |   1,290.22 ns |   1,077.39 ns |   104,100.0 ns |     544 B |
 **DequeueLeft**            | **1000000** | **6,875,100.0 ns** |  **62,424.69 ns** |  **58,392.10 ns** | **6,862,500.0 ns** |     **496 B** |
 DequeueRight           | 1000000 | 5,974,669.2 ns |  75,343.71 ns |  62,915.41 ns | 5,970,700.0 ns |     496 B |
 DequeueLeft_Prefilled  | 1000000 | 6,732,035.7 ns |  75,472.16 ns |  66,904.11 ns | 6,725,000.0 ns |     544 B |
 DequeueRight_Prefilled | 1000000 | 6,079,732.0 ns | 120,393.73 ns | 160,722.17 ns | 6,019,500.0 ns |     496 B |
