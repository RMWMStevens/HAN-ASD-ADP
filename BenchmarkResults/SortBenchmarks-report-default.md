
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-BTWGOS : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method     | Length | Algorithm        | Mean            | Error         | StdDev          | Median          | Gen0      | Allocated   |
----------- |------- |----------------- |----------------:|--------------:|----------------:|----------------:|----------:|------------:|
 **Ascending**  | **5**      | **Insertion**        |        **737.0 ns** |      **78.86 ns** |       **232.53 ns** |        **700.0 ns** |         **-** |       **640 B** |
 Descending | 5      | Insertion        |        604.5 ns |      51.01 ns |       141.35 ns |        600.0 ns |         - |       640 B |
 Random     | 5      | Insertion        |        710.5 ns |      57.17 ns |       164.04 ns |        700.0 ns |         - |       760 B |
 SameValue  | 5      | Insertion        |        598.9 ns |      40.88 ns |       115.31 ns |        600.0 ns |         - |       640 B |
 **Ascending**  | **5**      | **Merge**            |        **596.7 ns** |      **53.55 ns** |       **150.15 ns** |        **500.0 ns** |         **-** |       **808 B** |
 Descending | 5      | Merge            |        670.5 ns |      65.08 ns |       186.73 ns |        600.0 ns |         - |       808 B |
 Random     | 5      | Merge            |        667.7 ns |      64.41 ns |       188.89 ns |        600.0 ns |         - |       808 B |
 SameValue  | 5      | Merge            |        512.4 ns |      22.81 ns |        61.68 ns |        550.0 ns |         - |       808 B |
 **Ascending**  | **5**      | **Merge (Async)**    |      **5,862.4 ns** |     **137.62 ns** |       **381.33 ns** |      **5,750.0 ns** |         **-** |      **9664 B** |
 Descending | 5      | Merge (Async)    |      5,756.2 ns |     111.34 ns |       109.35 ns |      5,700.0 ns |         - |      9664 B |
 Random     | 5      | Merge (Async)    |      5,733.3 ns |     110.33 ns |       143.46 ns |      5,700.0 ns |         - |      9664 B |
 SameValue  | 5      | Merge (Async)    |      5,977.0 ns |     194.79 ns |       533.24 ns |      5,800.0 ns |         - |      9664 B |
 **Ascending**  | **5**      | **Merge (Parallel)** |     **57,314.3 ns** |   **2,488.46 ns** |     **7,258.95 ns** |     **57,350.0 ns** |         **-** |      **4960 B** |
 Descending | 5      | Merge (Parallel) |     54,096.8 ns |   2,397.64 ns |     6,840.60 ns |     53,600.0 ns |         - |      4512 B |
 Random     | 5      | Merge (Parallel) |     54,568.4 ns |   2,377.91 ns |     6,822.67 ns |     53,100.0 ns |         - |      5112 B |
 SameValue  | 5      | Merge (Parallel) |     55,842.9 ns |   2,974.32 ns |     8,676.23 ns |     54,750.0 ns |         - |      4624 B |
 **Ascending**  | **5**      | **Quick (High)**     |        **764.3 ns** |      **71.55 ns** |       **208.70 ns** |        **700.0 ns** |         **-** |       **784 B** |
 Descending | 5      | Quick (High)     |        576.5 ns |      52.20 ns |       141.12 ns |        500.0 ns |         - |       784 B |
 Random     | 5      | Quick (High)     |        703.4 ns |      44.72 ns |       122.43 ns |        700.0 ns |         - |       784 B |
 SameValue  | 5      | Quick (High)     |        682.8 ns |      48.37 ns |       137.23 ns |        600.0 ns |         - |       784 B |
 **Ascending**  | **5**      | **Quick (Middle)**   |        **600.0 ns** |      **45.73 ns** |       **128.24 ns** |        **600.0 ns** |         **-** |       **688 B** |
 Descending | 5      | Quick (Middle)   |        650.5 ns |      66.77 ns |       193.72 ns |        600.0 ns |         - |       688 B |
 Random     | 5      | Quick (Middle)   |        624.1 ns |      27.19 ns |        72.57 ns |        600.0 ns |         - |       760 B |
 SameValue  | 5      | Quick (Middle)   |        722.5 ns |      52.40 ns |       145.19 ns |        700.0 ns |         - |       784 B |
 **Ascending**  | **5**      | **Quick (Random)**   |        **794.6 ns** |      **51.86 ns** |       **146.28 ns** |        **800.0 ns** |         **-** |       **688 B** |
 Descending | 5      | Quick (Random)   |        695.5 ns |      44.35 ns |       122.15 ns |        650.0 ns |         - |       712 B |
 Random     | 5      | Quick (Random)   |        771.0 ns |      62.93 ns |       178.51 ns |        700.0 ns |         - |       712 B |
 SameValue  | 5      | Quick (Random)   |        994.9 ns |      85.54 ns |       250.87 ns |      1,000.0 ns |         - |       784 B |
 **Ascending**  | **5**      | **Selection**        |        **157.6 ns** |      **24.88 ns** |        **72.97 ns** |        **200.0 ns** |         **-** |       **544 B** |
 Descending | 5      | Selection        |        174.7 ns |      26.40 ns |        75.75 ns |        200.0 ns |         - |       544 B |
 Random     | 5      | Selection        |        180.3 ns |      15.74 ns |        40.07 ns |        200.0 ns |         - |       544 B |
 SameValue  | 5      | Selection        |        176.5 ns |      25.00 ns |        72.94 ns |        200.0 ns |         - |       544 B |
 **Ascending**  | **50**     | **Insertion**        |        **728.6 ns** |      **28.05 ns** |        **75.36 ns** |        **700.0 ns** |         **-** |      **1720 B** |
 Descending | 50     | Insertion        |        873.0 ns |      74.66 ns |       220.13 ns |        850.0 ns |         - |      1720 B |
 Random     | 50     | Insertion        |      4,267.7 ns |     187.55 ns |       532.05 ns |      4,100.0 ns |         - |     14200 B |
 SameValue  | 50     | Insertion        |        841.8 ns |      52.77 ns |       153.93 ns |        800.0 ns |         - |      1720 B |
 **Ascending**  | **50**     | **Merge**            |      **1,649.5 ns** |     **118.27 ns** |       **343.12 ns** |      **1,500.0 ns** |         **-** |      **4320 B** |
 Descending | 50     | Merge            |      1,849.0 ns |     176.69 ns |       520.97 ns |      1,750.0 ns |         - |      4320 B |
 Random     | 50     | Merge            |      2,612.1 ns |     101.40 ns |       284.35 ns |      2,600.0 ns |         - |      4320 B |
 SameValue  | 50     | Merge            |      1,421.8 ns |      69.45 ns |       190.12 ns |      1,400.0 ns |         - |      4320 B |
 **Ascending**  | **50**     | **Merge (Async)**    |     **46,231.2 ns** |     **882.73 ns** |       **866.96 ns** |     **45,900.0 ns** |         **-** |     **20376 B** |
 Descending | 50     | Merge (Async)    |     46,272.7 ns |     495.10 ns |       608.03 ns |     46,300.0 ns |         - |     20376 B |
 Random     | 50     | Merge (Async)    |     47,192.3 ns |     756.54 ns |       631.75 ns |     47,100.0 ns |         - |     20376 B |
 SameValue  | 50     | Merge (Async)    |     45,661.1 ns |     897.08 ns |       959.86 ns |     45,400.0 ns |         - |     20376 B |
 **Ascending**  | **50**     | **Merge (Parallel)** |    **108,881.2 ns** |   **3,261.35 ns** |     **9,409.75 ns** |    **107,450.0 ns** |         **-** |     **40120 B** |
 Descending | 50     | Merge (Parallel) |    103,983.2 ns |   2,484.41 ns |     7,128.23 ns |    103,100.0 ns |         - |     39344 B |
 Random     | 50     | Merge (Parallel) |    107,406.3 ns |   2,594.00 ns |     7,442.67 ns |    105,700.0 ns |         - |     38960 B |
 SameValue  | 50     | Merge (Parallel) |    104,191.2 ns |   2,419.77 ns |     7,020.21 ns |    103,550.0 ns |         - |     40080 B |
 **Ascending**  | **50**     | **Quick (High)**     |      **6,966.0 ns** |     **115.43 ns** |       **240.95 ns** |      **7,000.0 ns** |         **-** |     **29944 B** |
 Descending | 50     | Quick (High)     |      6,905.6 ns |     138.68 ns |       231.69 ns |      6,900.0 ns |         - |     29944 B |
 Random     | 50     | Quick (High)     |      3,183.0 ns |     143.89 ns |       424.28 ns |      3,000.0 ns |         - |      6280 B |
 SameValue  | 50     | Quick (High)     |      7,267.5 ns |     108.39 ns |       192.67 ns |      7,250.0 ns |         - |     29944 B |
 **Ascending**  | **50**     | **Quick (Middle)**   |      **1,794.6 ns** |     **103.08 ns** |       **292.43 ns** |      **1,700.0 ns** |         **-** |      **5176 B** |
 Descending | 50     | Quick (Middle)   |      1,729.9 ns |      77.21 ns |       211.37 ns |      1,700.0 ns |         - |      5176 B |
 Random     | 50     | Quick (Middle)   |      3,001.1 ns |     102.12 ns |       293.00 ns |      2,900.0 ns |         - |      6952 B |
 SameValue  | 50     | Quick (Middle)   |      7,269.0 ns |     147.12 ns |       215.64 ns |      7,300.0 ns |         - |     29944 B |
 **Ascending**  | **50**     | **Quick (Random)**   |      **2,688.8 ns** |     **148.40 ns** |       **432.90 ns** |      **2,500.0 ns** |         **-** |      **6256 B** |
 Descending | 50     | Quick (Random)   |      2,710.3 ns |     148.46 ns |       430.72 ns |      2,500.0 ns |         - |      7816 B |
 Random     | 50     | Quick (Random)   |      3,255.2 ns |     169.26 ns |       488.36 ns |      3,000.0 ns |         - |      6952 B |
 SameValue  | 50     | Quick (Random)   |      7,357.1 ns |     145.60 ns |       239.22 ns |      7,400.0 ns |         - |     29944 B |
 **Ascending**  | **50**     | **Selection**        |      **1,066.3 ns** |      **50.31 ns** |       **136.86 ns** |      **1,000.0 ns** |         **-** |       **544 B** |
 Descending | 50     | Selection        |      1,139.6 ns |      77.99 ns |       225.00 ns |      1,000.0 ns |         - |       544 B |
 Random     | 50     | Selection        |      2,146.5 ns |      57.42 ns |       156.20 ns |      2,100.0 ns |         - |       544 B |
 SameValue  | 50     | Selection        |      1,181.1 ns |      47.50 ns |       136.28 ns |      1,200.0 ns |         - |       544 B |
 **Ascending**  | **5000**   | **Insertion**        |     **23,968.8 ns** |     **280.00 ns** |       **275.00 ns** |     **23,900.0 ns** |         **-** |    **120520 B** |
 Descending | 5000   | Insertion        |     23,675.0 ns |     416.39 ns |       325.09 ns |     23,650.0 ns |         - |    120520 B |
 Random     | 5000   | Insertion        | 24,373,833.3 ns | 487,444.69 ns |   891,320.18 ns | 24,486,200.0 ns | 2000.0000 | 148972000 B |
 SameValue  | 5000   | Insertion        |     25,806.2 ns |     515.64 ns |       802.79 ns |     25,500.0 ns |         - |    120520 B |
 **Ascending**  | **5000**   | **Merge**            |    **114,592.9 ns** |   **1,983.93 ns** |     **1,758.70 ns** |    **114,650.0 ns** |         **-** |    **516528 B** |
 Descending | 5000   | Merge            |    117,002.9 ns |   2,323.73 ns |     3,817.95 ns |    116,400.0 ns |         - |    516528 B |
 Random     | 5000   | Merge            |    270,246.2 ns |   5,243.85 ns |     4,378.85 ns |    269,200.0 ns |         - |    516528 B |
 SameValue  | 5000   | Merge            |    113,447.4 ns |   2,199.77 ns |     2,445.03 ns |    112,900.0 ns |         - |    516528 B |
 **Ascending**  | **5000**   | **Merge (Async)**    |  **4,510,895.7 ns** |  **85,806.24 ns** |   **108,517.42 ns** |  **4,496,700.0 ns** |         **-** |   **1324584 B** |
 Descending | 5000   | Merge (Async)    |  4,472,076.3 ns |  72,564.52 ns |   125,170.23 ns |  4,446,700.0 ns |         - |   1324584 B |
 Random     | 5000   | Merge (Async)    |  4,662,014.3 ns |  21,184.89 ns |    18,779.85 ns |  4,662,650.0 ns |         - |   1324584 B |
 SameValue  | 5000   | Merge (Async)    |  4,597,170.0 ns |  64,162.99 ns |    73,890.19 ns |  4,588,300.0 ns |         - |   1324584 B |
 **Ascending**  | **5000**   | **Merge (Parallel)** |  **6,154,772.5 ns** | **122,883.56 ns** |   **251,018.55 ns** |  **6,179,600.0 ns** |         **-** |   **3764728 B** |
 Descending | 5000   | Merge (Parallel) |  7,815,393.9 ns | 963,537.39 ns | 2,825,888.38 ns |  6,315,600.0 ns |         - |  29546696 B |
 Random     | 5000   | Merge (Parallel) |  6,313,146.3 ns | 124,485.08 ns |   295,851.96 ns |  6,298,500.0 ns |         - |   3766400 B |
 SameValue  | 5000   | Merge (Parallel) |  6,243,073.5 ns | 120,333.82 ns |   194,316.69 ns |  6,250,200.0 ns |         - |   3766448 B |
 **Ascending**  | **5000**   | **Quick (High)**     | **51,277,231.2 ns** | **994,400.69 ns** | **1,548,162.08 ns** | **51,281,150.0 ns** | **5000.0000** | **299940496 B** |
 Descending | 5000   | Quick (High)     | 50,019,293.0 ns | 979,100.78 ns | 1,814,826.08 ns | 50,590,400.0 ns | 5000.0000 | 299945888 B |
 Random     | 5000   | Quick (High)     |    505,522.9 ns |   9,981.37 ns |    16,399.68 ns |    507,700.0 ns |         - |   1771768 B |
 SameValue  | 5000   | Quick (High)     | 48,536,454.2 ns | 958,423.80 ns | 1,246,221.66 ns | 48,667,000.0 ns | 5000.0000 | 299940496 B |
 **Ascending**  | **5000**   | **Quick (Middle)**   |    **293,230.3 ns** |  **10,575.39 ns** |    **31,015.79 ns** |    **282,300.0 ns** |         **-** |   **1244272 B** |
 Descending | 5000   | Quick (Middle)   |    280,559.7 ns |   5,534.36 ns |    12,604.53 ns |    278,600.0 ns |         - |   1244272 B |
 Random     | 5000   | Quick (Middle)   |    502,600.0 ns |   8,548.06 ns |    13,053.79 ns |    500,100.0 ns |         - |   1706464 B |
 SameValue  | 5000   | Quick (Middle)   | 48,517,722.7 ns | 946,213.19 ns | 1,162,034.77 ns | 48,724,250.0 ns | 5000.0000 | 299945888 B |
 **Ascending**  | **5000**   | **Quick (Random)**   |    **396,892.2 ns** |   **7,852.16 ns** |    **18,198.56 ns** |    **392,500.0 ns** |         **-** |   **1675384 B** |
 Descending | 5000   | Quick (Random)   |    401,062.0 ns |   7,873.04 ns |    15,903.93 ns |    400,950.0 ns |         - |   1707808 B |
 Random     | 5000   | Quick (Random)   |    502,913.6 ns |  10,017.91 ns |    12,302.90 ns |    503,800.0 ns |         - |   1685536 B |
 SameValue  | 5000   | Quick (Random)   | 43,578,711.1 ns | 865,187.23 ns |   925,740.64 ns | 43,645,700.0 ns | 5000.0000 | 299940496 B |
 **Ascending**  | **5000**   | **Selection**        |  **7,669,697.0 ns** | **158,712.59 ns** |   **465,476.55 ns** |  **7,763,200.0 ns** |         **-** |       **496 B** |
 Descending | 5000   | Selection        |  7,884,643.5 ns | 152,578.55 ns |   192,963.01 ns |  7,821,500.0 ns |         - |       544 B |
 Random     | 5000   | Selection        |  6,747,966.7 ns |  94,784.26 ns |    88,661.25 ns |  6,723,200.0 ns |         - |       544 B |
 SameValue  | 5000   | Selection        |  6,242,976.9 ns | 123,308.31 ns |   102,968.02 ns |  6,209,300.0 ns |         - |       544 B |
