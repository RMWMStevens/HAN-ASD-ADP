
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11370H 3.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-DNFAPA : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method     | Length | Algorithm        | Mean            | Error           | StdDev           | Median          | Gen0       | Gen1      | Allocated   |
----------- |------- |----------------- |----------------:|----------------:|-----------------:|----------------:|-----------:|----------:|------------:|
 **Ascending**  | **5**      | **Insertion**        |        **813.3 ns** |        **71.58 ns** |        **199.55 ns** |        **800.0 ns** |          **-** |         **-** |       **640 B** |
 Descending | 5      | Insertion        |        794.5 ns |        55.59 ns |        155.89 ns |        800.0 ns |          - |         - |       640 B |
 Random     | 5      | Insertion        |        801.1 ns |        34.26 ns |         96.64 ns |        800.0 ns |          - |         - |       664 B |
 SameValue  | 5      | Insertion        |        778.7 ns |        63.97 ns |        182.50 ns |        700.0 ns |          - |         - |       640 B |
 **Ascending**  | **5**      | **Merge**            |      **1,125.3 ns** |       **124.31 ns** |        **364.59 ns** |      **1,000.0 ns** |          **-** |         **-** |       **808 B** |
 Descending | 5      | Merge            |      1,131.0 ns |        85.24 ns |        251.34 ns |      1,200.0 ns |          - |         - |       808 B |
 Random     | 5      | Merge            |      1,093.0 ns |        90.22 ns |        266.00 ns |      1,000.0 ns |          - |         - |       808 B |
 SameValue  | 5      | Merge            |      1,338.9 ns |        74.59 ns |        214.03 ns |      1,400.0 ns |          - |         - |       808 B |
 **Ascending**  | **5**      | **Merge (Async)**    |      **5,256.8 ns** |       **263.07 ns** |        **724.58 ns** |      **4,950.0 ns** |          **-** |         **-** |      **1448 B** |
 Descending | 5      | Merge (Async)    |      8,546.3 ns |       505.06 ns |      1,449.12 ns |      8,700.0 ns |          - |         - |      1448 B |
 Random     | 5      | Merge (Async)    |      5,688.7 ns |       307.69 ns |        892.66 ns |      5,300.0 ns |          - |         - |      1448 B |
 SameValue  | 5      | Merge (Async)    |      8,080.0 ns |       688.14 ns |      2,028.98 ns |      7,850.0 ns |          - |         - |      1448 B |
 **Ascending**  | **5**      | **Merge (Parallel)** |     **51,916.0 ns** |     **2,166.82 ns** |      **6,182.05 ns** |     **51,450.0 ns** |          **-** |         **-** |      **4624 B** |
 Descending | 5      | Merge (Parallel) |     52,472.3 ns |     2,846.57 ns |      8,121.42 ns |     50,000.0 ns |          - |         - |      4624 B |
 Random     | 5      | Merge (Parallel) |     50,342.7 ns |     1,805.55 ns |      5,003.18 ns |     49,600.0 ns |          - |         - |      4648 B |
 SameValue  | 5      | Merge (Parallel) |     58,306.6 ns |     2,799.60 ns |      7,850.39 ns |     57,200.0 ns |          - |         - |      4576 B |
 **Ascending**  | **5**      | **Merge (slide)**    |        **797.8 ns** |        **48.75 ns** |        **138.30 ns** |        **800.0 ns** |          **-** |         **-** |       **592 B** |
 Descending | 5      | Merge (slide)    |        924.2 ns |        79.75 ns |        233.91 ns |        900.0 ns |          - |         - |       592 B |
 Random     | 5      | Merge (slide)    |        928.2 ns |        42.56 ns |        115.07 ns |        900.0 ns |          - |         - |       592 B |
 SameValue  | 5      | Merge (slide)    |        813.3 ns |        36.43 ns |         97.24 ns |        800.0 ns |          - |         - |       592 B |
 **Ascending**  | **5**      | **Quick (High)**     |        **947.9 ns** |        **52.66 ns** |        **150.25 ns** |        **850.0 ns** |          **-** |         **-** |       **784 B** |
 Descending | 5      | Quick (High)     |      1,079.9 ns |       108.34 ns |        314.30 ns |        950.0 ns |          - |         - |       784 B |
 Random     | 5      | Quick (High)     |      1,067.8 ns |        63.36 ns |        176.63 ns |      1,000.0 ns |          - |         - |       688 B |
 SameValue  | 5      | Quick (High)     |      1,334.3 ns |       113.94 ns |        334.16 ns |      1,300.0 ns |          - |         - |       784 B |
 **Ascending**  | **5**      | **Quick (Middle)**   |      **1,079.6 ns** |       **112.68 ns** |        **328.68 ns** |      **1,000.0 ns** |          **-** |         **-** |       **688 B** |
 Descending | 5      | Quick (Middle)   |      1,053.8 ns |        78.73 ns |        220.76 ns |      1,000.0 ns |          - |         - |       688 B |
 Random     | 5      | Quick (Middle)   |      1,005.3 ns |        64.78 ns |        185.87 ns |      1,000.0 ns |          - |         - |       688 B |
 SameValue  | 5      | Quick (Middle)   |      1,080.8 ns |       110.29 ns |        323.46 ns |      1,000.0 ns |          - |         - |       784 B |
 **Ascending**  | **5**      | **Quick (Random)**   |      **1,142.9 ns** |       **101.48 ns** |        **296.02 ns** |      **1,000.0 ns** |          **-** |         **-** |       **736 B** |
 Descending | 5      | Quick (Random)   |      1,232.7 ns |        95.80 ns |        279.46 ns |      1,100.0 ns |          - |         - |       688 B |
 Random     | 5      | Quick (Random)   |      1,107.3 ns |        97.29 ns |        280.69 ns |      1,000.0 ns |          - |         - |       760 B |
 SameValue  | 5      | Quick (Random)   |      1,129.6 ns |       105.26 ns |        307.03 ns |      1,000.0 ns |          - |         - |       784 B |
 **Ascending**  | **5**      | **Selection**        |        **181.4 ns** |        **43.18 ns** |        **125.27 ns** |        **200.0 ns** |          **-** |         **-** |       **544 B** |
 Descending | 5      | Selection        |        114.8 ns |        25.96 ns |         75.71 ns |        150.0 ns |          - |         - |       544 B |
 Random     | 5      | Selection        |        303.1 ns |        43.04 ns |        125.55 ns |        300.0 ns |          - |         - |       544 B |
 SameValue  | 5      | Selection        |        199.0 ns |        39.60 ns |        116.77 ns |        200.0 ns |          - |         - |       544 B |
 **Ascending**  | **50**     | **Insertion**        |        **972.4 ns** |        **61.96 ns** |        **169.60 ns** |        **900.0 ns** |          **-** |         **-** |      **1720 B** |
 Descending | 50     | Insertion        |        950.6 ns |        25.92 ns |         70.07 ns |        900.0 ns |          - |         - |      1720 B |
 Random     | 50     | Insertion        |      4,712.9 ns |       277.04 ns |        785.91 ns |      4,500.0 ns |          - |         - |     17584 B |
 SameValue  | 50     | Insertion        |      1,036.0 ns |        31.84 ns |         88.22 ns |      1,000.0 ns |          - |         - |      1720 B |
 **Ascending**  | **50**     | **Merge**            |      **1,858.3 ns** |        **56.38 ns** |        **151.47 ns** |      **1,800.0 ns** |          **-** |         **-** |      **4320 B** |
 Descending | 50     | Merge            |      1,911.6 ns |        49.85 ns |        135.62 ns |      1,850.0 ns |          - |         - |      4320 B |
 Random     | 50     | Merge            |      3,123.7 ns |       110.91 ns |        314.64 ns |      3,100.0 ns |          - |         - |      4320 B |
 SameValue  | 50     | Merge            |      2,223.5 ns |       142.57 ns |        415.87 ns |      2,100.0 ns |          - |         - |      4320 B |
 **Ascending**  | **50**     | **Merge (Async)**    |     **37,588.0 ns** |       **735.00 ns** |        **981.21 ns** |     **37,300.0 ns** |          **-** |         **-** |     **12160 B** |
 Descending | 50     | Merge (Async)    |     38,161.9 ns |       757.65 ns |        901.93 ns |     38,200.0 ns |          - |         - |     12160 B |
 Random     | 50     | Merge (Async)    |     38,726.3 ns |       769.97 ns |      1,328.16 ns |     38,300.0 ns |          - |         - |     12160 B |
 SameValue  | 50     | Merge (Async)    |     37,995.2 ns |       761.37 ns |        906.35 ns |     38,000.0 ns |          - |         - |     12160 B |
 **Ascending**  | **50**     | **Merge (Parallel)** |    **132,843.9 ns** |     **4,504.58 ns** |     **13,140.07 ns** |    **129,450.0 ns** |          **-** |         **-** |     **38192 B** |
 Descending | 50     | Merge (Parallel) |    127,984.7 ns |     3,537.20 ns |     10,318.18 ns |    126,250.0 ns |          - |         - |     37920 B |
 Random     | 50     | Merge (Parallel) |    131,918.9 ns |     3,738.25 ns |     10,725.75 ns |    130,300.0 ns |          - |         - |     38504 B |
 SameValue  | 50     | Merge (Parallel) |    130,797.9 ns |     3,957.11 ns |     11,480.29 ns |    126,900.0 ns |          - |         - |     38368 B |
 **Ascending**  | **50**     | **Merge (slide)**    |      **1,743.5 ns** |        **82.74 ns** |        **233.37 ns** |      **1,650.0 ns** |          **-** |         **-** |       **768 B** |
 Descending | 50     | Merge (slide)    |      1,795.9 ns |        83.68 ns |        242.78 ns |      1,700.0 ns |          - |         - |       768 B |
 Random     | 50     | Merge (slide)    |      2,825.0 ns |        77.54 ns |        218.70 ns |      2,800.0 ns |          - |         - |       768 B |
 SameValue  | 50     | Merge (slide)    |      1,764.4 ns |        58.42 ns |        159.93 ns |      1,700.0 ns |          - |         - |       768 B |
 **Ascending**  | **50**     | **Quick (High)**     |      **7,706.5 ns** |       **153.74 ns** |        **296.20 ns** |      **7,600.0 ns** |          **-** |         **-** |     **29944 B** |
 Descending | 50     | Quick (High)     |      7,731.1 ns |       155.60 ns |        296.05 ns |      7,700.0 ns |          - |         - |     29944 B |
 Random     | 50     | Quick (High)     |      3,320.2 ns |        77.03 ns |        219.77 ns |      3,300.0 ns |          - |         - |      6544 B |
 SameValue  | 50     | Quick (High)     |      8,260.0 ns |        67.61 ns |         63.25 ns |      8,300.0 ns |          - |         - |     29944 B |
 **Ascending**  | **50**     | **Quick (Middle)**   |      **2,115.4 ns** |        **81.31 ns** |        **228.00 ns** |      **2,100.0 ns** |          **-** |         **-** |      **5176 B** |
 Descending | 50     | Quick (Middle)   |      2,243.5 ns |        62.70 ns |        176.85 ns |      2,200.0 ns |          - |         - |      5176 B |
 Random     | 50     | Quick (Middle)   |      3,426.6 ns |        81.62 ns |        232.88 ns |      3,400.0 ns |          - |         - |      6832 B |
 SameValue  | 50     | Quick (Middle)   |      8,416.7 ns |       106.93 ns |         83.48 ns |      8,400.0 ns |          - |         - |     29944 B |
 **Ascending**  | **50**     | **Quick (Random)**   |      **3,066.7 ns** |        **74.19 ns** |        **214.07 ns** |      **3,000.0 ns** |          **-** |         **-** |      **7240 B** |
 Descending | 50     | Quick (Random)   |      3,106.3 ns |        72.76 ns |        208.75 ns |      3,100.0 ns |          - |         - |      6208 B |
 Random     | 50     | Quick (Random)   |      3,791.9 ns |       100.42 ns |        273.20 ns |      3,700.0 ns |          - |         - |      7360 B |
 SameValue  | 50     | Quick (Random)   |      8,435.0 ns |       160.05 ns |        184.32 ns |      8,400.0 ns |          - |         - |     29944 B |
 **Ascending**  | **50**     | **Selection**        |      **1,244.2 ns** |        **27.39 ns** |         **74.53 ns** |      **1,200.0 ns** |          **-** |         **-** |       **544 B** |
 Descending | 50     | Selection        |      1,275.6 ns |        26.87 ns |         71.25 ns |      1,300.0 ns |          - |         - |       544 B |
 Random     | 50     | Selection        |      2,776.0 ns |       127.91 ns |        377.16 ns |      2,600.0 ns |          - |         - |       544 B |
 SameValue  | 50     | Selection        |      1,233.8 ns |        26.56 ns |         68.08 ns |      1,200.0 ns |          - |         - |       544 B |
 **Ascending**  | **5000**   | **Insertion**        |     **26,776.9 ns** |       **342.76 ns** |        **286.22 ns** |     **26,600.0 ns** |          **-** |         **-** |    **120520 B** |
 Descending | 5000   | Insertion        |     27,531.2 ns |       499.80 ns |        490.88 ns |     27,500.0 ns |          - |         - |    120520 B |
 Random     | 5000   | Insertion        | 29,284,677.3 ns | 1,447,883.73 ns |  4,200,573.25 ns | 27,940,800.0 ns | 23000.0000 |         - | 148677784 B |
 SameValue  | 5000   | Insertion        |     31,312.5 ns |       544.99 ns |        535.26 ns |     31,400.0 ns |          - |         - |    120520 B |
 **Ascending**  | **5000**   | **Merge**            |    **153,623.5 ns** |     **2,030.42 ns** |      **4,054.98 ns** |    **152,850.0 ns** |          **-** |         **-** |    **516528 B** |
 Descending | 5000   | Merge            |    196,675.5 ns |    13,658.22 ns |     39,841.67 ns |    200,900.0 ns |          - |         - |    516528 B |
 Random     | 5000   | Merge            |    357,164.3 ns |     3,996.06 ns |      3,542.40 ns |    356,350.0 ns |          - |         - |    516528 B |
 SameValue  | 5000   | Merge            |    198,590.4 ns |    12,324.44 ns |     36,145.46 ns |    198,150.0 ns |          - |         - |    516528 B |
 **Ascending**  | **5000**   | **Merge (Async)**    |  **4,148,558.6 ns** |   **199,692.33 ns** |    **585,663.04 ns** |  **4,016,100.0 ns** |          **-** |         **-** |   **1316368 B** |
 Descending | 5000   | Merge (Async)    |  4,073,697.0 ns |   229,875.03 ns |    677,791.72 ns |  3,850,900.0 ns |          - |         - |   1316368 B |
 Random     | 5000   | Merge (Async)    |  4,026,705.3 ns |   131,160.80 ns |    374,209.13 ns |  3,983,800.0 ns |          - |         - |   1316368 B |
 SameValue  | 5000   | Merge (Async)    |  3,756,526.5 ns |    74,438.51 ns |    120,204.31 ns |  3,714,700.0 ns |          - |         - |   1316368 B |
 **Ascending**  | **5000**   | **Merge (Parallel)** | **18,238,893.0 ns** | **3,401,561.68 ns** | **10,029,581.37 ns** | **22,704,150.0 ns** |  **4000.0000** | **1000.0000** |  **29535944 B** |
 Descending | 5000   | Merge (Parallel) | 15,727,813.0 ns | 2,776,286.89 ns |  8,185,944.54 ns | 20,087,250.0 ns |          - |         - |   3761128 B |
 Random     | 5000   | Merge (Parallel) | 15,106,737.0 ns | 2,574,230.50 ns |  7,590,176.70 ns | 11,513,000.0 ns |          - |         - |   3761504 B |
 SameValue  | 5000   | Merge (Parallel) | 14,796,412.0 ns | 2,467,230.22 ns |  7,274,683.97 ns |  9,057,400.0 ns |  4000.0000 |         - |  29518456 B |
 **Ascending**  | **5000**   | **Merge (slide)**    |    **119,678.6 ns** |     **1,565.08 ns** |      **1,387.40 ns** |    **119,150.0 ns** |          **-** |         **-** |     **20568 B** |
 Descending | 5000   | Merge (slide)    |    119,150.0 ns |       963.93 ns |        752.57 ns |    119,200.0 ns |          - |         - |     20568 B |
 Random     | 5000   | Merge (slide)    |    336,681.8 ns |     6,624.42 ns |      8,135.38 ns |    332,600.0 ns |          - |         - |     20568 B |
 SameValue  | 5000   | Merge (slide)    |    118,884.6 ns |     1,500.39 ns |      1,252.89 ns |    118,800.0 ns |          - |         - |     20568 B |
 **Ascending**  | **5000**   | **Quick (High)**     | **67,747,578.9 ns** | **1,299,658.87 ns** |  **3,188,085.37 ns** | **67,578,700.0 ns** | **47000.0000** |         **-** | **299940544 B** |
 Descending | 5000   | Quick (High)     | 68,469,517.5 ns | 1,457,461.79 ns |  4,228,360.93 ns | 67,290,000.0 ns | 47000.0000 |         - | 299940544 B |
 Random     | 5000   | Quick (High)     |    576,550.0 ns |    10,896.01 ns |     10,701.34 ns |    576,100.0 ns |          - |         - |   1706680 B |
 SameValue  | 5000   | Quick (High)     | 56,096,098.9 ns | 1,119,779.47 ns |  3,065,378.24 ns | 55,527,400.0 ns | 47000.0000 |         - | 299940544 B |
 **Ascending**  | **5000**   | **Quick (Middle)**   |    **288,930.8 ns** |     **3,041.53 ns** |      **2,539.81 ns** |    **288,900.0 ns** |          **-** |         **-** |   **1244272 B** |
 Descending | 5000   | Quick (Middle)   |    289,515.4 ns |     2,491.37 ns |      2,080.40 ns |    288,700.0 ns |          - |         - |   1244272 B |
 Random     | 5000   | Quick (Middle)   |    586,187.7 ns |    11,015.97 ns |     25,749.48 ns |    578,600.0 ns |          - |         - |   1754392 B |
 SameValue  | 5000   | Quick (Middle)   | 58,151,501.0 ns | 1,568,679.07 ns |  4,551,022.43 ns | 57,531,700.0 ns | 47000.0000 |         - | 299940544 B |
 **Ascending**  | **5000**   | **Quick (Random)**   |    **447,366.7 ns** |     **8,820.56 ns** |     **17,410.93 ns** |    **445,650.0 ns** |          **-** |         **-** |   **1599736 B** |
 Descending | 5000   | Quick (Random)   |    588,816.0 ns |    45,782.29 ns |    134,990.12 ns |    562,950.0 ns |          - |         - |   1691272 B |
 Random     | 5000   | Quick (Random)   |    600,586.1 ns |    11,068.42 ns |     18,492.84 ns |    599,500.0 ns |          - |         - |   1758544 B |
 SameValue  | 5000   | Quick (Random)   | 51,817,230.3 ns | 1,304,340.34 ns |  3,825,404.43 ns | 50,798,000.0 ns | 47000.0000 |         - | 299940544 B |
 **Ascending**  | **5000**   | **Selection**        |  **7,371,858.3 ns** |   **116,978.23 ns** |     **91,328.91 ns** |  **7,355,950.0 ns** |          **-** |         **-** |       **544 B** |
 Descending | 5000   | Selection        |  7,389,423.1 ns |   103,752.10 ns |    142,017.04 ns |  7,393,700.0 ns |          - |         - |       544 B |
 Random     | 5000   | Selection        |  8,242,486.5 ns |   151,853.20 ns |    257,858.26 ns |  8,157,000.0 ns |          - |         - |       544 B |
 SameValue  | 5000   | Selection        |  7,436,661.8 ns |   139,711.04 ns |    225,607.29 ns |  7,357,850.0 ns |          - |         - |       544 B |
