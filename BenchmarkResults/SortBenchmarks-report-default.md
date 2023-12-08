
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-SVPVCU : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method     | Length | Algorithm           | Mean             | Error            | StdDev           | Median          | Gen0      | Allocated   |
----------- |------- |-------------------- |-----------------:|-----------------:|-----------------:|----------------:|----------:|------------:|
 **Ascending**  | **5**      | **Insertion**           |        **614.74 ns** |        **49.543 ns** |       **142.148 ns** |        **600.0 ns** |         **-** |       **640 B** |
 Descending | 5      | Insertion           |        801.52 ns |        71.649 ns |       210.133 ns |        750.0 ns |         - |       640 B |
 Random     | 5      | Insertion           |        752.13 ns |        52.601 ns |       150.074 ns |        700.0 ns |         - |       712 B |
 SameValue  | 5      | Insertion           |        683.67 ns |        77.315 ns |       225.532 ns |        600.0 ns |         - |       640 B |
 **Ascending**  | **5**      | **Merge V1**            |        **870.41 ns** |        **63.653 ns** |       **185.677 ns** |        **900.0 ns** |         **-** |       **808 B** |
 Descending | 5      | Merge V1            |        654.17 ns |        63.595 ns |       183.485 ns |        600.0 ns |         - |       808 B |
 Random     | 5      | Merge V1            |        687.10 ns |        45.377 ns |       128.728 ns |        600.0 ns |         - |       808 B |
 SameValue  | 5      | Merge V1            |        708.00 ns |        78.721 ns |       232.109 ns |        600.0 ns |         - |       808 B |
 **Ascending**  | **5**      | **Merge V1 (Async)**    |      **5,829.79 ns** |       **110.024 ns** |       **214.593 ns** |      **5,800.0 ns** |         **-** |      **1448 B** |
 Descending | 5      | Merge V1 (Async)    |      5,833.33 ns |       145.990 ns |       406.962 ns |      5,700.0 ns |         - |      1448 B |
 Random     | 5      | Merge V1 (Async)    |      6,028.67 ns |       123.481 ns |       312.052 ns |      5,950.0 ns |         - |      1448 B |
 SameValue  | 5      | Merge V1 (Async)    |      5,912.79 ns |       164.169 ns |       446.634 ns |      5,750.0 ns |         - |      1448 B |
 **Ascending**  | **5**      | **Merge V1 (Parallel)** |     **55,723.20 ns** |     **2,951.068 ns** |     **8,561.585 ns** |     **55,650.0 ns** |         **-** |      **4824 B** |
 Descending | 5      | Merge V1 (Parallel) |     54,289.00 ns |     2,837.413 ns |     8,366.176 ns |     53,700.0 ns |         - |      4624 B |
 Random     | 5      | Merge V1 (Parallel) |     54,279.80 ns |     2,558.618 ns |     7,503.985 ns |     53,600.0 ns |         - |      4912 B |
 SameValue  | 5      | Merge V1 (Parallel) |     54,965.66 ns |     2,841.794 ns |     8,334.489 ns |     55,100.0 ns |         - |      4624 B |
 **Ascending**  | **5**      | **Merge V2**            |        **565.79 ns** |        **56.226 ns** |       **161.322 ns** |        **550.0 ns** |         **-** |       **592 B** |
 Descending | 5      | Merge V2            |        497.59 ns |        26.797 ns |        71.527 ns |        500.0 ns |         - |       592 B |
 Random     | 5      | Merge V2            |        586.00 ns |        71.503 ns |       210.828 ns |        500.0 ns |         - |       592 B |
 SameValue  | 5      | Merge V2            |        663.64 ns |        64.336 ns |       188.687 ns |        600.0 ns |         - |       592 B |
 **Ascending**  | **5**      | **Merge V2 (Async)**    |      **6,332.29 ns** |       **318.234 ns** |       **918.178 ns** |      **5,800.0 ns** |         **-** |      **1232 B** |
 Descending | 5      | Merge V2 (Async)    |      5,673.68 ns |       107.470 ns |       119.453 ns |      5,700.0 ns |         - |      1232 B |
 Random     | 5      | Merge V2 (Async)    |      6,465.26 ns |       309.187 ns |       887.114 ns |      6,000.0 ns |         - |      1232 B |
 SameValue  | 5      | Merge V2 (Async)    |      5,926.44 ns |       173.273 ns |       474.332 ns |      5,800.0 ns |         - |      1232 B |
 **Ascending**  | **5**      | **Merge V2 (Parallel)** |     **36,117.00 ns** |     **1,549.252 ns** |     **4,568.006 ns** |     **33,950.0 ns** |         **-** |      **4392 B** |
 Descending | 5      | Merge V2 (Parallel) |     35,388.54 ns |     1,284.841 ns |     3,707.059 ns |     33,650.0 ns |         - |      4392 B |
 Random     | 5      | Merge V2 (Parallel) |     33,829.27 ns |       678.264 ns |     1,798.661 ns |     33,250.0 ns |         - |      4392 B |
 SameValue  | 5      | Merge V2 (Parallel) |     36,459.79 ns |     1,333.211 ns |     3,867.888 ns |     35,400.0 ns |         - |      4280 B |
 **Ascending**  | **5**      | **Quick (High)**        |        **762.37 ns** |        **49.283 ns** |       **139.809 ns** |        **700.0 ns** |         **-** |       **784 B** |
 Descending | 5      | Quick (High)        |        678.05 ns |        22.190 ns |        58.846 ns |        700.0 ns |         - |       784 B |
 Random     | 5      | Quick (High)        |        851.58 ns |        67.227 ns |       192.886 ns |        800.0 ns |         - |       688 B |
 SameValue  | 5      | Quick (High)        |        787.37 ns |        55.047 ns |       157.940 ns |        700.0 ns |         - |       784 B |
 **Ascending**  | **5**      | **Quick (Middle)**      |        **811.46 ns** |        **52.472 ns** |       **151.393 ns** |        **800.0 ns** |         **-** |       **688 B** |
 Descending | 5      | Quick (Middle)      |        729.63 ns |        25.068 ns |        66.039 ns |        700.0 ns |         - |       688 B |
 Random     | 5      | Quick (Middle)      |        602.38 ns |        25.171 ns |        67.621 ns |        600.0 ns |         - |       688 B |
 SameValue  | 5      | Quick (Middle)      |        773.63 ns |        64.856 ns |       181.864 ns |        700.0 ns |         - |       784 B |
 **Ascending**  | **5**      | **Quick (Random)**      |        **973.00 ns** |        **89.388 ns** |       **263.563 ns** |        **800.0 ns** |         **-** |       **736 B** |
 Descending | 5      | Quick (Random)      |        857.22 ns |        80.414 ns |       233.295 ns |        750.0 ns |         - |       688 B |
 Random     | 5      | Quick (Random)      |        832.10 ns |        26.042 ns |        68.606 ns |        800.0 ns |         - |       688 B |
 SameValue  | 5      | Quick (Random)      |        810.84 ns |        27.451 ns |        73.272 ns |        800.0 ns |         - |       784 B |
 **Ascending**  | **5**      | **Selection**           |         **84.42 ns** |        **14.242 ns** |        **36.509 ns** |        **100.0 ns** |         **-** |       **544 B** |
 Descending | 5      | Selection           |        152.53 ns |        23.025 ns |        67.527 ns |        100.0 ns |         - |       544 B |
 Random     | 5      | Selection           |        211.11 ns |        29.181 ns |        85.582 ns |        200.0 ns |         - |       544 B |
 SameValue  | 5      | Selection           |        165.00 ns |        22.287 ns |        65.713 ns |        200.0 ns |         - |       544 B |
 **Ascending**  | **50**     | **Insertion**           |        **700.00 ns** |         **0.000 ns** |         **0.000 ns** |        **700.0 ns** |         **-** |      **1720 B** |
 Descending | 50     | Insertion           |        823.81 ns |        38.598 ns |       103.690 ns |        800.0 ns |         - |      1720 B |
 Random     | 50     | Insertion           |      4,126.88 ns |       181.250 ns |       514.177 ns |      4,000.0 ns |         - |     18232 B |
 SameValue  | 50     | Insertion           |        822.62 ns |        30.220 ns |        81.183 ns |        800.0 ns |         - |      1720 B |
 **Ascending**  | **50**     | **Merge V1**            |      **1,366.28 ns** |        **48.045 ns** |       **130.709 ns** |      **1,300.0 ns** |         **-** |      **4320 B** |
 Descending | 50     | Merge V1            |      1,374.39 ns |        49.862 ns |       132.228 ns |      1,300.0 ns |         - |      4320 B |
 Random     | 50     | Merge V1            |      2,486.73 ns |       154.306 ns |       450.117 ns |      2,300.0 ns |         - |      4320 B |
 SameValue  | 50     | Merge V1            |      1,343.18 ns |        50.989 ns |       140.439 ns |      1,300.0 ns |         - |      4320 B |
 **Ascending**  | **50**     | **Merge V1 (Async)**    |     **46,223.08 ns** |       **700.252 ns** |       **584.742 ns** |     **46,100.0 ns** |         **-** |     **12160 B** |
 Descending | 50     | Merge V1 (Async)    |     46,248.48 ns |       887.734 ns |     1,408.040 ns |     45,700.0 ns |         - |     12160 B |
 Random     | 50     | Merge V1 (Async)    |     47,368.00 ns |       656.089 ns |     1,325.332 ns |     47,100.0 ns |         - |     12160 B |
 SameValue  | 50     | Merge V1 (Async)    |     45,958.33 ns |       733.675 ns |       572.805 ns |     45,950.0 ns |         - |     12160 B |
 **Ascending**  | **50**     | **Merge V1 (Parallel)** |    **115,042.86 ns** |     **3,460.174 ns** |    **10,093.491 ns** |    **115,300.0 ns** |         **-** |     **39056 B** |
 Descending | 50     | Merge V1 (Parallel) |    105,489.01 ns |     2,210.668 ns |     6,198.951 ns |    105,100.0 ns |         - |     40120 B |
 Random     | 50     | Merge V1 (Parallel) |    109,612.63 ns |     2,700.517 ns |     7,748.291 ns |    109,200.0 ns |         - |     39968 B |
 SameValue  | 50     | Merge V1 (Parallel) |    108,010.53 ns |     2,756.055 ns |     7,907.638 ns |    107,200.0 ns |         - |     39760 B |
 **Ascending**  | **50**     | **Merge V2**            |      **1,130.68 ns** |        **57.303 ns** |       **157.829 ns** |      **1,100.0 ns** |         **-** |       **768 B** |
 Descending | 50     | Merge V2            |      1,397.96 ns |       124.723 ns |       363.823 ns |      1,250.0 ns |         - |       768 B |
 Random     | 50     | Merge V2            |      2,257.14 ns |       135.078 ns |       394.028 ns |      2,100.0 ns |         - |       768 B |
 SameValue  | 50     | Merge V2            |      1,168.48 ns |        73.384 ns |       206.982 ns |      1,100.0 ns |         - |       768 B |
 **Ascending**  | **50**     | **Merge V2 (Async)**    |     **45,346.15 ns** |       **697.621 ns** |       **582.545 ns** |     **45,200.0 ns** |         **-** |      **8608 B** |
 Descending | 50     | Merge V2 (Async)    |     45,107.14 ns |       697.444 ns |       618.266 ns |     44,900.0 ns |         - |      8608 B |
 Random     | 50     | Merge V2 (Async)    |     45,550.00 ns |       581.853 ns |       454.273 ns |     45,550.0 ns |         - |      8608 B |
 SameValue  | 50     | Merge V2 (Async)    |     44,700.00 ns |       629.895 ns |       525.991 ns |     44,600.0 ns |         - |      8608 B |
 **Ascending**  | **50**     | **Merge V2 (Parallel)** |    **103,423.40 ns** |     **2,718.120 ns** |     **7,754.949 ns** |    **102,150.0 ns** |         **-** |     **36624 B** |
 Descending | 50     | Merge V2 (Parallel) |    104,832.29 ns |     3,257.844 ns |     9,399.625 ns |    102,750.0 ns |         - |     37144 B |
 Random     | 50     | Merge V2 (Parallel) |    106,423.71 ns |     3,691.258 ns |    10,709.009 ns |    103,400.0 ns |         - |     36944 B |
 SameValue  | 50     | Merge V2 (Parallel) |    102,608.33 ns |     2,488.481 ns |     7,179.835 ns |    101,500.0 ns |         - |     37296 B |
 **Ascending**  | **50**     | **Quick (High)**        |      **7,006.25 ns** |       **141.421 ns** |       **138.894 ns** |      **7,000.0 ns** |         **-** |     **29944 B** |
 Descending | 50     | Quick (High)        |      6,611.90 ns |       134.068 ns |       245.150 ns |      6,600.0 ns |         - |     29944 B |
 Random     | 50     | Quick (High)        |      2,829.17 ns |       146.609 ns |       423.001 ns |      2,700.0 ns |         - |      7120 B |
 SameValue  | 50     | Quick (High)        |      7,346.88 ns |       149.067 ns |       232.079 ns |      7,350.0 ns |         - |     29944 B |
 **Ascending**  | **50**     | **Quick (Middle)**      |      **1,844.44 ns** |        **87.601 ns** |       **244.196 ns** |      **1,750.0 ns** |         **-** |      **5176 B** |
 Descending | 50     | Quick (Middle)      |      2,043.43 ns |       137.872 ns |       404.354 ns |      1,900.0 ns |         - |      5176 B |
 Random     | 50     | Quick (Middle)      |      2,851.09 ns |        94.974 ns |       267.875 ns |      2,800.0 ns |         - |      5968 B |
 SameValue  | 50     | Quick (Middle)      |      7,338.24 ns |       144.641 ns |       233.569 ns |      7,300.0 ns |         - |     29944 B |
 **Ascending**  | **50**     | **Quick (Random)**      |      **2,910.31 ns** |       **172.737 ns** |       **501.141 ns** |      **2,700.0 ns** |         **-** |      **6568 B** |
 Descending | 50     | Quick (Random)      |      2,701.09 ns |       115.932 ns |       326.989 ns |      2,600.0 ns |         - |      7024 B |
 Random     | 50     | Quick (Random)      |      3,013.48 ns |        77.551 ns |       214.895 ns |      3,000.0 ns |         - |      6688 B |
 SameValue  | 50     | Quick (Random)      |      7,285.19 ns |       147.661 ns |       207.000 ns |      7,300.0 ns |         - |     29944 B |
 **Ascending**  | **50**     | **Selection**           |      **1,020.21 ns** |        **53.312 ns** |       **152.103 ns** |      **1,000.0 ns** |         **-** |       **544 B** |
 Descending | 50     | Selection           |      1,064.29 ns |        57.879 ns |       168.835 ns |      1,000.0 ns |         - |       544 B |
 Random     | 50     | Selection           |      2,043.33 ns |        42.327 ns |       106.965 ns |      2,050.0 ns |         - |       544 B |
 SameValue  | 50     | Selection           |        902.35 ns |        24.863 ns |        67.218 ns |        900.0 ns |         - |       544 B |
 **Ascending**  | **5000**   | **Insertion**           |     **23,332.00 ns** |       **456.529 ns** |       **609.453 ns** |     **23,400.0 ns** |         **-** |    **120520 B** |
 Descending | 5000   | Insertion           |     23,831.25 ns |       356.064 ns |       349.702 ns |     23,850.0 ns |         - |    120520 B |
 Random     | 5000   | Insertion           | 23,717,261.54 ns |   456,347.289 ns |   624,653.321 ns | 23,717,400.0 ns | 3000.0000 | 151605256 B |
 SameValue  | 5000   | Insertion           |     25,052.00 ns |       483.103 ns |       644.929 ns |     25,300.0 ns |         - |    120520 B |
 **Ascending**  | **5000**   | **Merge V1**            |    **116,453.33 ns** |     **2,185.929 ns** |     **3,271.795 ns** |    **115,300.0 ns** |         **-** |    **516528 B** |
 Descending | 5000   | Merge V1            |    118,436.00 ns |     2,139.896 ns |     2,856.700 ns |    117,300.0 ns |         - |    516528 B |
 Random     | 5000   | Merge V1            |    280,421.43 ns |     4,484.662 ns |     3,975.536 ns |    280,300.0 ns |         - |    516528 B |
 SameValue  | 5000   | Merge V1            |    112,626.67 ns |     1,714.533 ns |     1,603.775 ns |    111,800.0 ns |         - |    516528 B |
 **Ascending**  | **5000**   | **Merge V1 (Async)**    |  **4,610,330.30 ns** |    **86,038.900 ns** |   **136,466.813 ns** |  **4,560,500.0 ns** |         **-** |   **1316368 B** |
 Descending | 5000   | Merge V1 (Async)    |  4,517,561.54 ns |    68,952.500 ns |    94,382.961 ns |  4,483,100.0 ns |         - |   1316368 B |
 Random     | 5000   | Merge V1 (Async)    |  4,776,373.33 ns |    92,448.323 ns |    86,476.219 ns |  4,744,000.0 ns |         - |   1316368 B |
 SameValue  | 5000   | Merge V1 (Async)    |  4,555,013.95 ns |    90,821.025 ns |   168,342.594 ns |  4,469,300.0 ns |         - |   1316368 B |
 **Ascending**  | **5000**   | **Merge V1 (Parallel)** |  **6,254,944.90 ns** |   **123,194.019 ns** |   **246,031.768 ns** |  **6,242,400.0 ns** |         **-** |   **3765608 B** |
 Descending | 5000   | Merge V1 (Parallel) |  6,111,065.12 ns |   122,058.293 ns |   332,068.587 ns |  6,093,700.0 ns |         - |   3767720 B |
 Random     | 5000   | Merge V1 (Parallel) |  6,160,710.84 ns |   130,110.690 ns |   347,291.771 ns |  6,182,500.0 ns |         - |   3828248 B |
 SameValue  | 5000   | Merge V1 (Parallel) |  6,101,493.33 ns |   121,670.524 ns |   182,110.711 ns |  6,100,150.0 ns |         - |   3767552 B |
 **Ascending**  | **5000**   | **Merge V2**            |     **90,600.00 ns** |       **483.980 ns** |       **404.145 ns** |     **90,500.0 ns** |         **-** |     **20568 B** |
 Descending | 5000   | Merge V2            |     91,653.85 ns |     1,325.988 ns |     1,107.260 ns |     92,000.0 ns |         - |     20568 B |
 Random     | 5000   | Merge V2            |    258,169.23 ns |     3,338.604 ns |     2,787.886 ns |    258,000.0 ns |         - |     20568 B |
 SameValue  | 5000   | Merge V2            |     94,707.69 ns |       589.642 ns |       492.378 ns |     94,700.0 ns |         - |     20568 B |
 **Ascending**  | **5000**   | **Merge V2 (Async)**    |  **4,532,676.92 ns** |    **56,365.703 ns** |    **47,067.915 ns** |  **4,529,800.0 ns** |         **-** |    **820408 B** |
 Descending | 5000   | Merge V2 (Async)    |  4,513,959.09 ns |    89,308.597 ns |   141,652.900 ns |  4,447,450.0 ns |         - |    820408 B |
 Random     | 5000   | Merge V2 (Async)    |  4,619,100.00 ns |    49,171.431 ns |    38,389.819 ns |  4,607,300.0 ns |         - |    820408 B |
 SameValue  | 5000   | Merge V2 (Async)    |  4,467,893.33 ns |    34,082.621 ns |    31,880.905 ns |  4,464,700.0 ns |         - |    820408 B |
 **Ascending**  | **5000**   | **Merge V2 (Parallel)** |  **6,082,215.15 ns** |   **116,184.206 ns** |   **184,280.462 ns** |  **6,071,800.0 ns** |         **-** |   **3427824 B** |
 Descending | 5000   | Merge V2 (Parallel) |  8,803,957.00 ns |   895,661.547 ns | 2,640,878.278 ns |  9,636,100.0 ns |         - |   3429872 B |
 Random     | 5000   | Merge V2 (Parallel) |  6,106,302.33 ns |   119,298.400 ns |   221,127.234 ns |  6,119,600.0 ns |         - |   3427432 B |
 SameValue  | 5000   | Merge V2 (Parallel) |  8,762,987.00 ns | 1,189,572.759 ns | 3,507,482.118 ns |  6,417,750.0 ns |         - |  29215840 B |
 **Ascending**  | **5000**   | **Quick (High)**        | **43,806,080.95 ns** |   **868,511.545 ns** | **1,033,901.213 ns** | **43,721,900.0 ns** | **5000.0000** | **299940496 B** |
 Descending | 5000   | Quick (High)        | 46,273,682.35 ns |   905,758.822 ns |   930,147.624 ns | 46,203,500.0 ns | 5000.0000 | 299940496 B |
 Random     | 5000   | Quick (High)        |    505,667.35 ns |     9,070.026 ns |    18,113.823 ns |    505,200.0 ns |         - |   1747168 B |
 SameValue  | 5000   | Quick (High)        | 42,558,685.71 ns |   838,976.764 ns | 1,534,116.453 ns | 42,349,350.0 ns | 5000.0000 | 299940496 B |
 **Ascending**  | **5000**   | **Quick (Middle)**      |    **269,888.89 ns** |     **5,249.079 ns** |     **5,616.456 ns** |    **272,100.0 ns** |         **-** |   **1244272 B** |
 Descending | 5000   | Quick (Middle)      |    276,952.00 ns |     5,537.499 ns |     7,392.402 ns |    274,400.0 ns |         - |   1244272 B |
 Random     | 5000   | Quick (Middle)      |    491,903.77 ns |     9,160.181 ns |    19,120.709 ns |    487,200.0 ns |         - |   1835080 B |
 SameValue  | 5000   | Quick (Middle)      | 43,084,938.89 ns |   850,635.576 ns |   910,170.536 ns | 43,376,750.0 ns | 5000.0000 | 299940496 B |
 **Ascending**  | **5000**   | **Quick (Random)**      |    **399,987.88 ns** |     **7,545.798 ns** |    **17,786.335 ns** |    **398,300.0 ns** |         **-** |   **1685464 B** |
 Descending | 5000   | Quick (Random)      |    419,924.00 ns |     8,267.627 ns |    16,701.015 ns |    418,050.0 ns |         - |   1716280 B |
 Random     | 5000   | Quick (Random)      |    507,757.50 ns |    10,079.435 ns |    17,916.185 ns |    505,050.0 ns |         - |   1744720 B |
 SameValue  | 5000   | Quick (Random)      | 50,703,333.84 ns | 1,056,966.260 ns | 3,099,899.072 ns | 51,624,050.0 ns | 5000.0000 | 299940496 B |
 **Ascending**  | **5000**   | **Selection**           |  **7,766,550.00 ns** |   **105,985.469 ns** |    **93,953.358 ns** |  **7,755,300.0 ns** |         **-** |       **544 B** |
 Descending | 5000   | Selection           |  7,738,364.29 ns |   108,772.437 ns |    96,423.933 ns |  7,708,250.0 ns |         - |       544 B |
 Random     | 5000   | Selection           |  6,640,561.54 ns |    47,351.800 ns |    39,540.897 ns |  6,643,000.0 ns |         - |       544 B |
 SameValue  | 5000   | Selection           |  6,283,876.19 ns |   114,471.471 ns |   136,270.143 ns |  6,222,300.0 ns |         - |       544 B |
