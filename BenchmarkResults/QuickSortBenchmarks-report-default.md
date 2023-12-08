
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-VYMOSY : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method     | Length | Algorithm      | Mean                | Error             | StdDev           | Median              | Gen0         | Gen1      | Allocated      |
----------- |------- |--------------- |--------------------:|------------------:|-----------------:|--------------------:|-------------:|----------:|---------------:|
 **Ascending**  | **10**     | **Quick (High)**   |          **1,026.0 ns** |          **87.92 ns** |         **259.2 ns** |            **900.0 ns** |            **-** |         **-** |         **1624 B** |
 Descending | 10     | Quick (High)   |            947.4 ns |          72.23 ns |         207.2 ns |            800.0 ns |            - |         - |         1624 B |
 Random     | 10     | Quick (High)   |          1,029.3 ns |          90.11 ns |         264.3 ns |            900.0 ns |            - |         - |         1384 B |
 SameValue  | 10     | Quick (High)   |          1,061.2 ns |          84.64 ns |         246.9 ns |          1,000.0 ns |            - |         - |         1624 B |
 **Ascending**  | **10**     | **Quick (Middle)** |          **1,008.0 ns** |         **101.19 ns** |         **298.4 ns** |            **900.0 ns** |            **-** |         **-** |         **1000 B** |
 Descending | 10     | Quick (Middle) |          1,019.0 ns |          95.77 ns |         282.4 ns |          1,000.0 ns |            - |         - |         1000 B |
 Random     | 10     | Quick (Middle) |          1,120.2 ns |          93.69 ns |         274.8 ns |          1,100.0 ns |            - |         - |         1192 B |
 SameValue  | 10     | Quick (Middle) |          1,113.1 ns |         112.63 ns |         330.3 ns |          1,000.0 ns |            - |         - |         1624 B |
 **Ascending**  | **10**     | **Quick (Random)** |          **1,109.1 ns** |          **83.96 ns** |         **246.2 ns** |          **1,100.0 ns** |            **-** |         **-** |         **1024 B** |
 Descending | 10     | Quick (Random) |          1,137.4 ns |         103.17 ns |         302.6 ns |          1,000.0 ns |            - |         - |         1168 B |
 Random     | 10     | Quick (Random) |          1,210.2 ns |         102.96 ns |         300.3 ns |          1,200.0 ns |            - |         - |         1408 B |
 SameValue  | 10     | Quick (Random) |          1,231.6 ns |          92.96 ns |         271.2 ns |          1,100.0 ns |            - |         - |         1624 B |
 **Ascending**  | **100**    | **Quick (High)**   |         **24,546.7 ns** |         **470.99 ns** |         **440.6 ns** |         **24,600.0 ns** |            **-** |         **-** |       **119344 B** |
 Descending | 100    | Quick (High)   |         23,396.8 ns |         241.18 ns |         368.3 ns |         23,400.0 ns |            - |         - |       119344 B |
 Random     | 100    | Quick (High)   |          6,104.3 ns |         206.39 ns |         585.5 ns |          6,000.0 ns |            - |         - |        15256 B |
 SameValue  | 100    | Quick (High)   |         26,933.3 ns |         448.16 ns |         349.9 ns |         27,000.0 ns |            - |         - |       119344 B |
 **Ascending**  | **100**    | **Quick (Middle)** |          **3,864.5 ns** |         **172.27 ns** |         **488.7 ns** |          **3,800.0 ns** |            **-** |         **-** |        **12064 B** |
 Descending | 100    | Quick (Middle) |          4,042.1 ns |         213.19 ns |         611.7 ns |          3,900.0 ns |            - |         - |        12064 B |
 Random     | 100    | Quick (Middle) |          6,314.8 ns |         152.01 ns |         418.7 ns |          6,300.0 ns |            - |         - |        19672 B |
 SameValue  | 100    | Quick (Middle) |         24,890.5 ns |         491.19 ns |         584.7 ns |         24,900.0 ns |            - |         - |       119344 B |
 **Ascending**  | **100**    | **Quick (Random)** |          **5,694.8 ns** |         **258.99 ns** |         **747.3 ns** |          **5,600.0 ns** |            **-** |         **-** |        **17392 B** |
 Descending | 100    | Quick (Random) |          5,627.1 ns |         259.29 ns |         748.1 ns |          5,400.0 ns |            - |         - |        15064 B |
 Random     | 100    | Quick (Random) |          6,489.1 ns |         169.54 ns |         478.2 ns |          6,500.0 ns |            - |         - |        13960 B |
 SameValue  | 100    | Quick (Random) |         27,457.1 ns |         405.50 ns |         809.8 ns |         27,300.0 ns |            - |         - |       119344 B |
 **Ascending**  | **1000**   | **Quick (High)**   |      **2,360,147.9 ns** |      **46,625.06 ns** |      **92,033.3 ns** |      **2,345,600.0 ns** |            **-** |         **-** |     **11988544 B** |
 Descending | 1000   | Quick (High)   |      2,046,662.0 ns |     130,479.19 ns |     384,720.8 ns |      2,009,900.0 ns |            - |         - |     11988544 B |
 Random     | 1000   | Quick (High)   |         77,874.6 ns |       1,541.61 ns |       3,663.8 ns |         77,500.0 ns |            - |         - |       274168 B |
 SameValue  | 1000   | Quick (High)   |      2,260,311.0 ns |     154,328.59 ns |     455,041.3 ns |      2,421,900.0 ns |            - |         - |     11988544 B |
 **Ascending**  | **1000**   | **Quick (Middle)** |         **44,394.7 ns** |         **872.45 ns** |       **1,504.9 ns** |         **44,000.0 ns** |            **-** |         **-** |       **192232 B** |
 Descending | 1000   | Quick (Middle) |         43,100.0 ns |         846.38 ns |       1,266.8 ns |         43,000.0 ns |            - |         - |       192232 B |
 Random     | 1000   | Quick (Middle) |         83,313.0 ns |       1,640.36 ns |       3,460.1 ns |         83,000.0 ns |            - |         - |       258712 B |
 SameValue  | 1000   | Quick (Middle) |      2,114,738.0 ns |     156,857.66 ns |     462,498.3 ns |      2,211,500.0 ns |            - |         - |     11988544 B |
 **Ascending**  | **1000**   | **Quick (Random)** |         **67,423.1 ns** |       **1,795.66 ns** |       **5,035.2 ns** |         **66,500.0 ns** |            **-** |         **-** |       **267232 B** |
 Descending | 1000   | Quick (Random) |         65,890.0 ns |       1,409.79 ns |       3,929.9 ns |         65,850.0 ns |            - |         - |       254224 B |
 Random     | 1000   | Quick (Random) |         88,014.3 ns |       1,751.73 ns |       3,498.4 ns |         87,600.0 ns |            - |         - |       247816 B |
 SameValue  | 1000   | Quick (Random) |      2,100,372.0 ns |     136,227.84 ns |     401,670.9 ns |      2,179,200.0 ns |            - |         - |     11988544 B |
 **Ascending**  | **10000**  | **Quick (High)**   |    **210,328,580.0 ns** |   **3,858,320.55 ns** |   **3,609,075.4 ns** |    **210,967,800.0 ns** |   **23000.0000** |         **-** |   **1199880536 B** |
 Descending | 10000  | Quick (High)   |    209,569,659.1 ns |   4,165,053.69 ns |   5,115,060.0 ns |    209,295,400.0 ns |   23000.0000 |         - |   1199885888 B |
 Random     | 10000  | Quick (High)   |      1,059,395.6 ns |      20,570.62 ns |      39,137.7 ns |      1,055,300.0 ns |            - |         - |      3770920 B |
 SameValue  | 10000  | Quick (High)   |    198,093,676.9 ns |   3,933,304.25 ns |   6,888,865.1 ns |    198,350,600.0 ns |   23000.0000 |         - |   1199880496 B |
 **Ascending**  | **10000**  | **Quick (Middle)** |        **573,889.5 ns** |      **11,323.25 ns** |      **24,615.8 ns** |        **567,500.0 ns** |            **-** |         **-** |      **2727688 B** |
 Descending | 10000  | Quick (Middle) |        580,004.5 ns |       9,596.16 ns |      22,806.3 ns |        574,300.0 ns |            - |         - |      2727688 B |
 Random     | 10000  | Quick (Middle) |      1,149,628.7 ns |      30,739.75 ns |      87,702.2 ns |      1,129,850.0 ns |            - |         - |      3981784 B |
 SameValue  | 10000  | Quick (Middle) |    194,560,266.7 ns |   3,849,738.06 ns |   6,106,092.5 ns |    194,172,400.0 ns |   23000.0000 |         - |   1199880496 B |
 **Ascending**  | **10000**  | **Quick (Random)** |        **958,414.3 ns** |      **27,771.92 ns** |      **81,012.0 ns** |        **946,750.0 ns** |            **-** |         **-** |      **4099888 B** |
 Descending | 10000  | Quick (Random) |        942,524.7 ns |      25,756.33 ns |      73,066.4 ns |        922,400.0 ns |            - |         - |      3549256 B |
 Random     | 10000  | Quick (Random) |      1,120,083.9 ns |      22,132.73 ns |      47,643.0 ns |      1,116,150.0 ns |            - |         - |      3707680 B |
 SameValue  | 10000  | Quick (Random) |    207,242,300.0 ns |   4,107,471.69 ns |   5,044,344.1 ns |    207,135,300.0 ns |   23000.0000 |         - |   1199880496 B |
 **Ascending**  | **100000** | **Quick (High)**   |                  **NA** |                **NA** |               **NA** |                  **NA** |           **NA** |        **NA** |             **NA** |
 Descending | 100000 | Quick (High)   |                  NA |                NA |               NA |                  NA |           NA |        NA |             NA |
 Random     | 100000 | Quick (High)   |     11,927,243.3 ns |     358,901.08 ns |   1,041,237.1 ns |     11,691,100.0 ns |            - |         - |     49953448 B |
 SameValue  | 100000 | Quick (High)   | 22,210,242,429.6 ns | 441,543,378.38 ns | 618,982,149.5 ns | 22,186,709,300.0 ns | 2391000.0000 | 2000.0000 | 119998913728 B |
 **Ascending**  | **100000** | **Quick (Middle)** |      **5,811,990.0 ns** |     **179,358.03 ns** |     **499,978.5 ns** |      **5,746,200.0 ns** |            **-** |         **-** |     **35255200 B** |
 Descending | 100000 | Quick (Middle) |      6,174,567.1 ns |     186,876.88 ns |     505,232.5 ns |      6,122,600.0 ns |            - |         - |     35255200 B |
 Random     | 100000 | Quick (Middle) |     12,366,935.0 ns |     226,442.74 ns |     402,501.7 ns |     12,340,750.0 ns |            - |         - |     47319184 B |
 SameValue  | 100000 | Quick (Middle) | 18,089,893,053.3 ns | 224,288,099.99 ns | 209,799,227.9 ns | 18,058,967,100.0 ns | 2391000.0000 | 1000.0000 | 119998897552 B |
 **Ascending**  | **100000** | **Quick (Random)** |      **8,194,842.0 ns** |     **160,287.90 ns** |     **323,789.5 ns** |      **8,249,850.0 ns** |            **-** |         **-** |     **47638240 B** |
 Descending | 100000 | Quick (Random) |      8,323,000.0 ns |     165,643.70 ns |     360,095.8 ns |      8,234,300.0 ns |            - |         - |     48886048 B |
 Random     | 100000 | Quick (Random) |     11,164,993.9 ns |     219,732.11 ns |     348,518.4 ns |     11,095,800.0 ns |            - |         - |     48000688 B |
 SameValue  | 100000 | Quick (Random) | 19,536,035,671.4 ns | 142,187,263.97 ns | 126,045,306.0 ns | 19,526,129,750.0 ns | 2391000.0000 | 1000.0000 | 119998908336 B |

Benchmarks with issues:
  QuickSortBenchmarks.Ascending: Job-VYMOSY(InvocationCount=1, UnrollFactor=1) [Length=100000, Algorithm=Quick (High)]
  QuickSortBenchmarks.Descending: Job-VYMOSY(InvocationCount=1, UnrollFactor=1) [Length=100000, Algorithm=Quick (High)]
