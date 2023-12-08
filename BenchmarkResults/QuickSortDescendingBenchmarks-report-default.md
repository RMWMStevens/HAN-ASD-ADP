
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-CXVDAV : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method     | Length | Algorithm      | Mean             | Error           | StdDev          | Median           | Gen0       | Allocated    |
----------- |------- |--------------- |-----------------:|----------------:|----------------:|-----------------:|-----------:|-------------:|
 **Descending** | **10**     | **Quick (High)**   |       **1,123.0 ns** |        **97.11 ns** |        **286.3 ns** |       **1,150.0 ns** |          **-** |       **1624 B** |
 **Descending** | **10**     | **Quick (Middle)** |         **880.4 ns** |        **93.29 ns** |        **270.7 ns** |         **800.0 ns** |          **-** |       **1000 B** |
 **Descending** | **10**     | **Quick (Random)** |       **1,338.0 ns** |       **106.68 ns** |        **314.6 ns** |       **1,300.0 ns** |          **-** |       **1024 B** |
 **Descending** | **100**    | **Quick (High)**   |      **25,563.6 ns** |       **477.15 ns** |        **586.0 ns** |      **25,500.0 ns** |          **-** |     **119344 B** |
 **Descending** | **100**    | **Quick (Middle)** |       **3,773.9 ns** |       **147.16 ns** |        **415.1 ns** |       **3,600.0 ns** |          **-** |      **12064 B** |
 **Descending** | **100**    | **Quick (Random)** |       **5,379.3 ns** |       **192.59 ns** |        **543.2 ns** |       **5,300.0 ns** |          **-** |      **18856 B** |
 **Descending** | **1000**   | **Quick (High)**   |   **2,446,477.5 ns** |    **48,889.27 ns** |     **86,900.6 ns** |   **2,431,750.0 ns** |          **-** |   **11988544 B** |
 **Descending** | **1000**   | **Quick (Middle)** |      **42,253.3 ns** |       **596.42 ns** |        **557.9 ns** |      **42,200.0 ns** |          **-** |     **192232 B** |
 **Descending** | **1000**   | **Quick (Random)** |      **71,192.1 ns** |     **1,422.07 ns** |      **3,267.4 ns** |      **70,800.0 ns** |          **-** |     **279640 B** |
 **Descending** | **10000**  | **Quick (High)**   | **217,846,969.9 ns** | **4,344,857.22 ns** | **10,820,202.2 ns** | **215,939,100.0 ns** | **23000.0000** | **1199880496 B** |
 **Descending** | **10000**  | **Quick (Middle)** |     **623,287.0 ns** |    **12,337.75 ns** |     **15,603.3 ns** |     **622,500.0 ns** |          **-** |    **2727688 B** |
 **Descending** | **10000**  | **Quick (Random)** |     **904,082.1 ns** |    **17,897.08 ns** |     **42,534.3 ns** |     **901,100.0 ns** |          **-** |    **3642736 B** |
 **Descending** | **100000** | **Quick (High)**   |               **NA** |              **NA** |              **NA** |               **NA** |         **NA** |           **NA** |
 **Descending** | **100000** | **Quick (Middle)** |   **5,378,143.8 ns** |   **106,617.38 ns** |    **278,999.1 ns** |   **5,343,900.0 ns** |          **-** |   **35255200 B** |
 **Descending** | **100000** | **Quick (Random)** |   **8,879,512.4 ns** |   **186,227.80 ns** |    **516,036.3 ns** |   **8,797,800.0 ns** |  **1000.0000** |   **50218600 B** |

Benchmarks with issues:
  QuickSortDescendingBenchmarks.Descending: Job-CXVDAV(InvocationCount=1, UnrollFactor=1) [Length=100000, Algorithm=Quick (High)]
