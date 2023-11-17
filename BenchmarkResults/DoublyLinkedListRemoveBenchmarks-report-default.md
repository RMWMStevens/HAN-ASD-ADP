
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-BIRKPB : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method     | Times | Length  | Mean            | Error         | StdDev          | Median          | Gen0      | Allocated   |
----------- |------ |-------- |----------------:|--------------:|----------------:|----------------:|----------:|------------:|
 **Remove_Min** | **1**     | **100**     |        **410.0 ns** |      **30.44 ns** |        **84.87 ns** |        **400.0 ns** |         **-** |       **568 B** |
 Remove_Mid | 1     | 100     |        479.5 ns |      33.10 ns |        91.17 ns |        500.0 ns |         - |      1768 B |
 Remove_Max | 1     | 100     |        527.1 ns |      24.47 ns |        66.17 ns |        500.0 ns |         - |      2944 B |
 **Remove_Min** | **1**     | **10000**   |        **554.1 ns** |      **67.16 ns** |       **195.92 ns** |        **500.0 ns** |         **-** |       **568 B** |
 Remove_Mid | 1     | 10000   |      9,877.3 ns |     196.15 ns |       240.89 ns |      9,850.0 ns |         - |    120568 B |
 Remove_Max | 1     | 10000   |     19,336.0 ns |     368.80 ns |       492.34 ns |     19,200.0 ns |         - |    240544 B |
 **Remove_Min** | **1**     | **1000000** |      **1,321.9 ns** |     **129.41 ns** |       **373.38 ns** |      **1,200.0 ns** |         **-** |       **520 B** |
 Remove_Mid | 1     | 1000000 |  1,051,115.4 ns |  19,608.05 ns |    34,341.91 ns |  1,047,000.0 ns |         - |  12000520 B |
 Remove_Max | 1     | 1000000 |  2,170,801.8 ns |  43,232.21 ns |    93,061.88 ns |  2,145,800.0 ns |         - |  24000496 B |
 **Remove_Min** | **5**     | **100**     |        **525.3 ns** |      **26.06 ns** |        **69.57 ns** |        **500.0 ns** |         **-** |       **664 B** |
 Remove_Mid | 5     | 100     |              NA |            NA |              NA |              NA |        NA |          NA |
 Remove_Max | 5     | 100     |      1,490.0 ns |      52.43 ns |       146.15 ns |      1,500.0 ns |         - |     12304 B |
 **Remove_Min** | **5**     | **10000**   |        **636.0 ns** |      **77.81 ns** |       **229.41 ns** |        **500.0 ns** |         **-** |       **664 B** |
 Remove_Mid | 5     | 10000   |              NA |            NA |              NA |              NA |        NA |          NA |
 Remove_Max | 5     | 10000   |     92,980.0 ns |   1,857.04 ns |     1,737.07 ns |     92,600.0 ns |         - |   1200304 B |
 **Remove_Min** | **5**     | **1000000** |      **1,382.7 ns** |      **90.90 ns** |       **265.17 ns** |      **1,300.0 ns** |         **-** |       **616 B** |
 Remove_Mid | 5     | 1000000 |              NA |            NA |              NA |              NA |        NA |          NA |
 Remove_Max | 5     | 1000000 | 14,022,366.0 ns | 539,790.85 ns | 1,566,031.12 ns | 14,640,100.0 ns | 2000.0000 | 120000256 B |
 **Remove_Min** | **10**    | **100**     |        **702.2 ns** |      **50.39 ns** |       **142.93 ns** |        **600.0 ns** |         **-** |       **784 B** |
 Remove_Mid | 10    | 100     |              NA |            NA |              NA |              NA |        NA |          NA |
 Remove_Max | 10    | 100     |      2,637.2 ns |     119.88 ns |       342.03 ns |      2,500.0 ns |         - |     23464 B |
 **Remove_Min** | **10**    | **10000**   |        **742.6 ns** |      **69.05 ns** |       **197.02 ns** |        **700.0 ns** |         **-** |       **784 B** |
 Remove_Mid | 10    | 10000   |              NA |            NA |              NA |              NA |        NA |          NA |
 Remove_Max | 10    | 10000   |    190,219.4 ns |   3,685.40 ns |     5,627.99 ns |    188,900.0 ns |         - |   2399464 B |
 **Remove_Min** | **10**    | **1000000** |      **1,257.4 ns** |      **78.37 ns** |       **223.60 ns** |      **1,200.0 ns** |         **-** |       **736 B** |
 Remove_Mid | 10    | 1000000 |              NA |            NA |              NA |              NA |        NA |          NA |
 Remove_Max | 10    | 1000000 | 24,681,368.1 ns | 558,995.67 ns | 1,594,846.09 ns | 25,005,350.0 ns | 4000.0000 | 239999416 B |

Benchmarks with issues:
  DoublyLinkedListRemoveBenchmarks.Remove_Mid: Job-BIRKPB(InvocationCount=1, UnrollFactor=1) [Times=5, Length=100]
  DoublyLinkedListRemoveBenchmarks.Remove_Mid: Job-BIRKPB(InvocationCount=1, UnrollFactor=1) [Times=5, Length=10000]
  DoublyLinkedListRemoveBenchmarks.Remove_Mid: Job-BIRKPB(InvocationCount=1, UnrollFactor=1) [Times=5, Length=1000000]
  DoublyLinkedListRemoveBenchmarks.Remove_Mid: Job-BIRKPB(InvocationCount=1, UnrollFactor=1) [Times=10, Length=100]
  DoublyLinkedListRemoveBenchmarks.Remove_Mid: Job-BIRKPB(InvocationCount=1, UnrollFactor=1) [Times=10, Length=10000]
  DoublyLinkedListRemoveBenchmarks.Remove_Mid: Job-BIRKPB(InvocationCount=1, UnrollFactor=1) [Times=10, Length=1000000]
