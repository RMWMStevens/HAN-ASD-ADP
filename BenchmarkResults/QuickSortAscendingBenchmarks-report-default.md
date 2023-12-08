
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-CXVDAV : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method    | Length | Algorithm      | Mean             | Error           | StdDev         | Median           | Gen0       | Allocated    |
---------- |------- |--------------- |-----------------:|----------------:|---------------:|-----------------:|-----------:|-------------:|
 **Ascending** | **10**     | **Quick (High)**   |         **959.2 ns** |        **64.90 ns** |       **189.3 ns** |         **900.0 ns** |          **-** |       **1624 B** |
 **Ascending** | **10**     | **Quick (Middle)** |         **900.0 ns** |        **83.10 ns** |       **242.4 ns** |         **800.0 ns** |          **-** |       **1000 B** |
 **Ascending** | **10**     | **Quick (Random)** |       **1,161.0 ns** |        **89.65 ns** |       **264.3 ns** |       **1,100.0 ns** |          **-** |       **1048 B** |
 **Ascending** | **100**    | **Quick (High)**   |      **28,124.1 ns** |       **479.32 ns** |     **1,011.1 ns** |      **28,000.0 ns** |          **-** |     **119344 B** |
 **Ascending** | **100**    | **Quick (Middle)** |       **3,900.0 ns** |       **134.73 ns** |       **382.2 ns** |       **3,800.0 ns** |          **-** |      **12064 B** |
 **Ascending** | **100**    | **Quick (Random)** |       **5,971.0 ns** |       **261.09 ns** |       **740.7 ns** |       **5,700.0 ns** |          **-** |      **14944 B** |
 **Ascending** | **1000**   | **Quick (High)**   |   **2,349,670.4 ns** |   **173,274.66 ns** |   **505,450.3 ns** |   **2,503,850.0 ns** |          **-** |   **11988544 B** |
 **Ascending** | **1000**   | **Quick (Middle)** |      **42,820.7 ns** |       **819.76 ns** |     **1,201.6 ns** |      **42,900.0 ns** |          **-** |     **192232 B** |
 **Ascending** | **1000**   | **Quick (Random)** |      **66,270.3 ns** |     **1,410.29 ns** |     **3,954.6 ns** |      **65,600.0 ns** |          **-** |     **238216 B** |
 **Ascending** | **10000**  | **Quick (High)**   | **210,871,325.9 ns** | **4,092,976.93 ns** | **5,737,782.0 ns** | **209,062,600.0 ns** | **23000.0000** | **1199880496 B** |
 **Ascending** | **10000**  | **Quick (Middle)** |     **628,203.3 ns** |    **11,620.34 ns** |    **17,392.8 ns** |     **627,700.0 ns** |          **-** |    **2727688 B** |
 **Ascending** | **10000**  | **Quick (Random)** |     **903,360.0 ns** |    **22,884.32 ns** |    **63,792.3 ns** |     **889,150.0 ns** |          **-** |    **3629200 B** |
 **Ascending** | **100000** | **Quick (High)**   |               **NA** |              **NA** |             **NA** |               **NA** |         **NA** |           **NA** |
 **Ascending** | **100000** | **Quick (Middle)** |   **5,376,898.4 ns** |   **106,463.32 ns** |   **246,744.9 ns** |   **5,322,300.0 ns** |          **-** |   **35255200 B** |
 **Ascending** | **100000** | **Quick (Random)** |   **8,988,225.8 ns** |   **184,922.75 ns** |   **512,420.1 ns** |   **8,968,800.0 ns** |          **-** |   **48401464 B** |

Benchmarks with issues:
  QuickSortAscendingBenchmarks.Ascending: Job-CXVDAV(InvocationCount=1, UnrollFactor=1) [Length=100000, Algorithm=Quick (High)]
