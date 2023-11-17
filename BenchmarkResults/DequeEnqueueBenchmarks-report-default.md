
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-GGXILR : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                 | Times   | Mean           | Error         | StdDev        | Median         | Allocated  |
----------------------- |-------- |---------------:|--------------:|--------------:|---------------:|-----------:|
 **EnqueueLeft_Empty**      | **1**       |       **456.0 ns** |      **58.90 ns** |     **173.68 ns** |       **400.0 ns** |      **592 B** |
 EnqueueRight_Empty     | 1       |       457.7 ns |      58.62 ns |     170.07 ns |       400.0 ns |      592 B |
 EnqueueLeft_Prefilled  | 1       |       350.0 ns |      26.89 ns |      73.16 ns |       300.0 ns |      592 B |
 EnqueueRight_Prefilled | 1       |       418.8 ns |      48.84 ns |     140.91 ns |       400.0 ns |      592 B |
 **EnqueueLeft_Empty**      | **100**     |     **1,190.5 ns** |      **27.48 ns** |      **73.83 ns** |     **1,200.0 ns** |     **5344 B** |
 EnqueueRight_Empty     | 100     |     1,176.3 ns |      54.86 ns |     155.62 ns |     1,100.0 ns |     5344 B |
 EnqueueLeft_Prefilled  | 100     |     1,180.2 ns |      44.69 ns |     121.58 ns |     1,100.0 ns |     5344 B |
 EnqueueRight_Prefilled | 100     |     1,108.6 ns |      23.97 ns |      58.34 ns |     1,100.0 ns |     5344 B |
 **EnqueueLeft_Empty**      | **10000**   |    **90,392.3 ns** |   **1,768.46 ns** |   **1,476.74 ns** |    **90,000.0 ns** |   **480544 B** |
 EnqueueRight_Empty     | 10000   |    80,245.5 ns |     758.35 ns |     931.32 ns |    80,250.0 ns |   480544 B |
 EnqueueLeft_Prefilled  | 10000   |    88,261.5 ns |   1,054.85 ns |     880.85 ns |    88,500.0 ns |   480544 B |
 EnqueueRight_Prefilled | 10000   |    76,858.3 ns |     832.70 ns |     650.12 ns |    76,700.0 ns |   480544 B |
 **EnqueueLeft_Empty**      | **1000000** | **9,441,908.3 ns** |  **78,062.33 ns** |  **60,945.93 ns** | **9,447,700.0 ns** | **48000496 B** |
 EnqueueRight_Empty     | 1000000 | 8,565,994.4 ns | 165,855.75 ns | 177,463.80 ns | 8,486,650.0 ns | 48000496 B |
 EnqueueLeft_Prefilled  | 1000000 | 9,222,720.0 ns | 149,941.07 ns | 140,254.97 ns | 9,190,800.0 ns | 48000496 B |
 EnqueueRight_Prefilled | 1000000 | 8,239,878.9 ns | 151,565.85 ns | 168,465.04 ns | 8,186,800.0 ns | 48000496 B |
