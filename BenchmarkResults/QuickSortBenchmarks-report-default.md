
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11370H 3.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-FNFWYH : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method     | Length | Algorithm      | Mean             | Error           | StdDev           | Median           | Gen0        | Gen1      | Allocated    |
----------- |------- |--------------- |-----------------:|----------------:|-----------------:|-----------------:|------------:|----------:|-------------:|
 **Ascending**  | **10**     | **Quick (High)**   |       **1,398.0 ns** |       **144.52 ns** |        **421.58 ns** |       **1,300.0 ns** |           **-** |         **-** |       **1624 B** |
 Descending | 10     | Quick (High)   |       1,116.5 ns |        43.85 ns |        127.21 ns |       1,100.0 ns |           - |         - |       1624 B |
 Random     | 10     | Quick (High)   |       1,642.4 ns |       137.43 ns |        403.07 ns |       1,800.0 ns |           - |         - |       1048 B |
 SameValue  | 10     | Quick (High)   |       1,848.0 ns |       113.92 ns |        335.89 ns |       1,900.0 ns |           - |         - |       1624 B |
 **Ascending**  | **10**     | **Quick (Median)** |       **1,384.4 ns** |        **56.63 ns** |        **157.87 ns** |       **1,300.0 ns** |           **-** |         **-** |       **1360 B** |
 Descending | 10     | Quick (Median) |       1,303.2 ns |        41.26 ns |        117.73 ns |       1,300.0 ns |           - |         - |       1360 B |
 Random     | 10     | Quick (Median) |       1,395.6 ns |        68.43 ns |        190.75 ns |       1,300.0 ns |           - |         - |       1456 B |
 SameValue  | 10     | Quick (Median) |       1,520.5 ns |        52.31 ns |        150.09 ns |       1,450.0 ns |           - |         - |       2272 B |
 **Ascending**  | **10**     | **Quick (Middle)** |       **1,107.9 ns** |        **40.06 ns** |        **111.01 ns** |       **1,100.0 ns** |           **-** |         **-** |       **1000 B** |
 Descending | 10     | Quick (Middle) |         967.8 ns |        25.22 ns |         69.04 ns |       1,000.0 ns |           - |         - |       1000 B |
 Random     | 10     | Quick (Middle) |       1,127.1 ns |        33.47 ns |         90.49 ns |       1,100.0 ns |           - |         - |       1000 B |
 SameValue  | 10     | Quick (Middle) |       1,210.1 ns |        28.81 ns |         79.84 ns |       1,200.0 ns |           - |         - |       1624 B |
 **Ascending**  | **10**     | **Quick (Random)** |       **1,177.8 ns** |        **50.95 ns** |        **142.04 ns** |       **1,200.0 ns** |           **-** |         **-** |       **1096 B** |
 Descending | 10     | Quick (Random) |       1,274.2 ns |        61.26 ns |        173.77 ns |       1,200.0 ns |           - |         - |       1096 B |
 Random     | 10     | Quick (Random) |       1,306.6 ns |        50.38 ns |        141.27 ns |       1,300.0 ns |           - |         - |       1192 B |
 SameValue  | 10     | Quick (Random) |       1,506.2 ns |        85.13 ns |        246.99 ns |       1,400.0 ns |           - |         - |       1624 B |
 **Ascending**  | **100**    | **Quick (High)**   |      **31,778.3 ns** |       **633.74 ns** |      **1,417.46 ns** |      **31,100.0 ns** |           **-** |         **-** |     **119344 B** |
 Descending | 100    | Quick (High)   |      31,831.7 ns |       638.89 ns |      1,152.05 ns |      31,300.0 ns |           - |         - |     119344 B |
 Random     | 100    | Quick (High)   |       7,807.7 ns |       206.66 ns |        579.51 ns |       7,600.0 ns |           - |         - |      14464 B |
 SameValue  | 100    | Quick (High)   |      35,925.0 ns |       716.37 ns |      1,273.35 ns |      35,500.0 ns |           - |         - |     119344 B |
 **Ascending**  | **100**    | **Quick (Median)** |       **5,862.2 ns** |       **120.84 ns** |        **229.91 ns** |       **5,800.0 ns** |           **-** |         **-** |      **15736 B** |
 Descending | 100    | Quick (Median) |       6,038.0 ns |       119.13 ns |        240.65 ns |       6,000.0 ns |           - |         - |      15736 B |
 Random     | 100    | Quick (Median) |       9,483.3 ns |       191.37 ns |        483.61 ns |       9,450.0 ns |           - |         - |      19048 B |
 SameValue  | 100    | Quick (Median) |      38,838.8 ns |       720.46 ns |      1,712.25 ns |      38,500.0 ns |           - |         - |     126472 B |
 **Ascending**  | **100**    | **Quick (Middle)** |       **4,688.2 ns** |       **127.93 ns** |        **362.91 ns** |       **4,600.0 ns** |           **-** |         **-** |      **12064 B** |
 Descending | 100    | Quick (Middle) |       4,658.7 ns |        88.61 ns |        170.72 ns |       4,600.0 ns |           - |         - |      12064 B |
 Random     | 100    | Quick (Middle) |       7,835.4 ns |       191.56 ns |        552.69 ns |       7,800.0 ns |           - |         - |      16816 B |
 SameValue  | 100    | Quick (Middle) |      35,958.5 ns |       718.02 ns |      1,498.77 ns |      35,400.0 ns |           - |         - |     119344 B |
 **Ascending**  | **100**    | **Quick (Random)** |       **6,689.2 ns** |       **205.11 ns** |        **581.88 ns** |       **6,600.0 ns** |           **-** |         **-** |      **14536 B** |
 Descending | 100    | Quick (Random) |       6,744.2 ns |       148.98 ns |        427.44 ns |       6,600.0 ns |           - |         - |      21160 B |
 Random     | 100    | Quick (Random) |       8,308.2 ns |       168.54 ns |        488.98 ns |       8,200.0 ns |           - |         - |      15712 B |
 SameValue  | 100    | Quick (Random) |      33,412.5 ns |       395.00 ns |        387.94 ns |      33,300.0 ns |           - |         - |     119344 B |
 **Ascending**  | **1000**   | **Quick (High)**   |   **2,756,039.0 ns** |   **272,070.26 ns** |    **802,205.29 ns** |   **2,929,500.0 ns** |   **1000.0000** |         **-** |   **11988544 B** |
 Descending | 1000   | Quick (High)   |   2,880,066.2 ns |   263,034.37 ns |    771,434.28 ns |   3,009,850.0 ns |   1000.0000 | 1000.0000 |   11988544 B |
 Random     | 1000   | Quick (High)   |     105,689.6 ns |     2,092.03 ns |      4,971.93 ns |     105,500.0 ns |           - |         - |     248920 B |
 SameValue  | 1000   | Quick (High)   |   3,489,528.0 ns |   369,899.89 ns |  1,090,658.18 ns |   3,545,300.0 ns |   1000.0000 |         - |   11988544 B |
 **Ascending**  | **1000**   | **Quick (Median)** |      **61,838.0 ns** |     **1,202.29 ns** |      **1,605.02 ns** |      **61,950.0 ns** |           **-** |         **-** |     **217312 B** |
 Descending | 1000   | Quick (Median) |      61,650.0 ns |     1,229.51 ns |      1,877.59 ns |      61,050.0 ns |           - |         - |     217312 B |
 Random     | 1000   | Quick (Median) |     111,348.7 ns |     2,218.93 ns |      3,886.27 ns |     111,500.0 ns |           - |         - |     261088 B |
 SameValue  | 1000   | Quick (Median) |   3,059,121.0 ns |   291,190.67 ns |    858,582.26 ns |   3,152,150.0 ns |   1000.0000 | 1000.0000 |   12060472 B |
 **Ascending**  | **1000**   | **Quick (Middle)** |      **55,405.9 ns** |     **1,076.70 ns** |      **1,738.68 ns** |      **54,950.0 ns** |           **-** |         **-** |     **192232 B** |
 Descending | 1000   | Quick (Middle) |      54,104.2 ns |     1,014.84 ns |      1,319.58 ns |      53,550.0 ns |           - |         - |     192232 B |
 Random     | 1000   | Quick (Middle) |     106,520.5 ns |     2,114.81 ns |      3,703.92 ns |     106,800.0 ns |           - |         - |     250288 B |
 SameValue  | 1000   | Quick (Middle) |   3,578,560.0 ns |    67,088.70 ns |    100,415.21 ns |   3,605,900.0 ns |   1000.0000 | 1000.0000 |   11988544 B |
 **Ascending**  | **1000**   | **Quick (Random)** |      **84,556.4 ns** |     **1,691.49 ns** |      **4,366.27 ns** |      **84,100.0 ns** |           **-** |         **-** |     **283336 B** |
 Descending | 1000   | Quick (Random) |      81,921.4 ns |     1,541.76 ns |      2,211.14 ns |      81,550.0 ns |           - |         - |     256648 B |
 Random     | 1000   | Quick (Random) |     107,541.5 ns |     2,142.06 ns |      5,006.99 ns |     106,600.0 ns |           - |         - |     266608 B |
 SameValue  | 1000   | Quick (Random) |   3,307,380.8 ns |    64,741.75 ns |     88,619.24 ns |   3,283,300.0 ns |   1000.0000 | 1000.0000 |   11988544 B |
 **Ascending**  | **10000**  | **Quick (High)**   | **322,834,015.4 ns** | **5,018,142.37 ns** |  **4,190,376.15 ns** | **324,022,300.0 ns** | **191000.0000** |         **-** | **1199880592 B** |
 Descending | 10000  | Quick (High)   | 325,805,942.9 ns | 6,438,398.99 ns |  7,664,456.00 ns | 325,647,600.0 ns | 191000.0000 |         - | 1199880544 B |
 Random     | 10000  | Quick (High)   |   1,315,092.9 ns |    62,677.82 ns |    183,823.21 ns |   1,364,400.0 ns |           - |         - |    3634024 B |
 SameValue  | 10000  | Quick (High)   | 222,297,406.7 ns | 3,207,507.46 ns |  3,000,304.47 ns | 221,668,000.0 ns | 191000.0000 |         - | 1199880592 B |
 **Ascending**  | **10000**  | **Quick (Median)** |     **857,000.0 ns** |     **8,656.80 ns** |      **7,674.03 ns** |     **853,450.0 ns** |           **-** |         **-** |    **3054496 B** |
 Descending | 10000  | Quick (Median) |     829,269.2 ns |     8,735.80 ns |      7,294.79 ns |     827,500.0 ns |           - |         - |    3054496 B |
 Random     | 10000  | Quick (Median) |   1,343,097.9 ns |    86,163.96 ns |    247,220.57 ns |   1,384,500.0 ns |           - |         - |    3611416 B |
 SameValue  | 10000  | Quick (Median) | 223,768,023.3 ns | 4,392,481.98 ns |  4,108,730.37 ns | 222,512,850.0 ns | 191000.0000 |         - | 1200600520 B |
 **Ascending**  | **10000**  | **Quick (Middle)** |     **744,091.7 ns** |     **6,434.07 ns** |      **5,023.30 ns** |     **743,900.0 ns** |           **-** |         **-** |    **2727688 B** |
 Descending | 10000  | Quick (Middle) |     749,041.7 ns |     5,885.67 ns |      4,595.15 ns |     746,950.0 ns |           - |         - |    2727688 B |
 Random     | 10000  | Quick (Middle) |   1,435,592.9 ns |    28,653.65 ns |     52,394.81 ns |   1,435,150.0 ns |           - |         - |    3542272 B |
 SameValue  | 10000  | Quick (Middle) | 232,390,629.3 ns | 4,582,231.69 ns | 10,058,109.65 ns | 229,108,850.0 ns | 191000.0000 |         - | 1199880544 B |
 **Ascending**  | **10000**  | **Quick (Random)** |   **1,028,922.9 ns** |    **57,672.09 ns** |    **166,397.16 ns** |   **1,075,400.0 ns** |           **-** |         **-** |    **3902512 B** |
 Descending | 10000  | Quick (Random) |   1,114,829.5 ns |    21,808.42 ns |     40,961.51 ns |   1,110,900.0 ns |           - |         - |    3641200 B |
 Random     | 10000  | Quick (Random) |   1,436,478.4 ns |    28,273.92 ns |     48,011.26 ns |   1,434,000.0 ns |           - |         - |    3762976 B |
 SameValue  | 10000  | Quick (Random) | 199,009,764.3 ns | 2,639,542.31 ns |  2,339,885.51 ns | 199,706,750.0 ns | 191000.0000 |         - | 1199880544 B |
