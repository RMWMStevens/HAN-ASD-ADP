
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-FSENXI : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method     | Length | Algorithm        | Mean            | Error           | StdDev          | Median          | Gen0       | Allocated   |
----------- |------- |----------------- |----------------:|----------------:|----------------:|----------------:|-----------:|------------:|
 **Ascending**  | **3**      | **Insertion**        |        **857.6 ns** |        **70.77 ns** |       **207.56 ns** |        **900.0 ns** |          **-** |       **592 B** |
 Descending | 3      | Insertion        |        754.1 ns |        64.02 ns |       186.76 ns |        800.0 ns |          - |       592 B |
 Random     | 3      | Insertion        |        570.2 ns |        56.73 ns |       161.86 ns |        500.0 ns |          - |       616 B |
 SameValue  | 3      | Insertion        |        758.0 ns |        78.20 ns |       230.58 ns |        700.0 ns |          - |       592 B |
 **Ascending**  | **3**      | **Merge**            |        **624.5 ns** |        **73.52 ns** |       **214.46 ns** |        **500.0 ns** |          **-** |       **672 B** |
 Descending | 3      | Merge            |        693.0 ns |        83.95 ns |       247.51 ns |        600.0 ns |          - |       672 B |
 Random     | 3      | Merge            |        590.5 ns |        60.60 ns |       173.86 ns |        500.0 ns |          - |       672 B |
 SameValue  | 3      | Merge            |        523.4 ns |        53.52 ns |       152.70 ns |        500.0 ns |          - |       672 B |
 **Ascending**  | **3**      | **Merge (Async)**    |      **4,326.4 ns** |       **172.09 ns** |       **482.55 ns** |      **4,100.0 ns** |          **-** |       **992 B** |
 Descending | 3      | Merge (Async)    |      4,606.1 ns |       257.42 ns |       750.92 ns |      4,300.0 ns |          - |       992 B |
 Random     | 3      | Merge (Async)    |      3,960.0 ns |        81.12 ns |       133.28 ns |      3,900.0 ns |          - |       992 B |
 SameValue  | 3      | Merge (Async)    |      4,249.4 ns |       135.59 ns |       375.72 ns |      4,200.0 ns |          - |       992 B |
 **Ascending**  | **3**      | **Merge (Parallel)** |     **46,828.7 ns** |     **1,641.25 ns** |     **4,682.58 ns** |     **45,750.0 ns** |          **-** |      **2944 B** |
 Descending | 3      | Merge (Parallel) |     42,849.5 ns |     1,682.76 ns |     4,881.98 ns |     41,400.0 ns |          - |      2944 B |
 Random     | 3      | Merge (Parallel) |     42,022.2 ns |     1,775.82 ns |     5,208.17 ns |     39,900.0 ns |          - |      2944 B |
 SameValue  | 3      | Merge (Parallel) |     43,912.2 ns |     1,083.87 ns |     3,161.70 ns |     44,150.0 ns |          - |      2944 B |
 **Ascending**  | **3**      | **Selection**        |        **159.0 ns** |        **23.17 ns** |        **68.31 ns** |        **150.0 ns** |          **-** |       **544 B** |
 Descending | 3      | Selection        |        137.0 ns |        19.67 ns |        58.01 ns |        100.0 ns |          - |       544 B |
 Random     | 3      | Selection        |        176.0 ns |        22.15 ns |        65.32 ns |        200.0 ns |          - |       544 B |
 SameValue  | 3      | Selection        |        164.6 ns |        28.11 ns |        82.45 ns |        200.0 ns |          - |       544 B |
 **Ascending**  | **100**    | **Insertion**        |      **1,245.4 ns** |        **47.47 ns** |       **137.70 ns** |      **1,300.0 ns** |          **-** |      **2920 B** |
 Descending | 100    | Insertion        |      1,287.0 ns |        72.89 ns |       214.93 ns |      1,200.0 ns |          - |      2920 B |
 Random     | 100    | Insertion        |     14,475.3 ns |       351.62 ns |     1,020.11 ns |     14,500.0 ns |          - |     61672 B |
 SameValue  | 100    | Insertion        |      1,106.4 ns |        78.59 ns |       224.24 ns |      1,000.0 ns |          - |      2920 B |
 **Ascending**  | **100**    | **Merge**            |      **2,502.2 ns** |       **114.96 ns** |       **320.46 ns** |      **2,400.0 ns** |          **-** |      **8544 B** |
 Descending | 100    | Merge            |      2,565.3 ns |       172.31 ns |       494.39 ns |      2,300.0 ns |          - |      8544 B |
 Random     | 100    | Merge            |      4,621.4 ns |       130.50 ns |       350.58 ns |      4,600.0 ns |          - |      8544 B |
 SameValue  | 100    | Merge            |      2,222.4 ns |        56.90 ns |       153.82 ns |      2,200.0 ns |          - |      8544 B |
 **Ascending**  | **100**    | **Merge (Async)**    |     **90,915.4 ns** |       **819.31 ns** |       **684.16 ns** |     **90,600.0 ns** |          **-** |     **24384 B** |
 Descending | 100    | Merge (Async)    |     91,584.6 ns |     1,373.13 ns |     1,146.62 ns |     91,000.0 ns |          - |     24384 B |
 Random     | 100    | Merge (Async)    |     98,784.6 ns |     1,334.28 ns |     1,114.19 ns |     98,700.0 ns |          - |     24384 B |
 SameValue  | 100    | Merge (Async)    |     91,460.0 ns |     1,750.03 ns |     1,636.98 ns |     90,900.0 ns |          - |     24384 B |
 **Ascending**  | **100**    | **Merge (Parallel)** |    **163,203.1 ns** |     **3,742.29 ns** |    **10,916.43 ns** |    **163,200.0 ns** |          **-** |     **77016 B** |
 Descending | 100    | Merge (Parallel) |    163,537.5 ns |     3,250.72 ns |     8,953.43 ns |    162,150.0 ns |          - |     77248 B |
 Random     | 100    | Merge (Parallel) |    165,660.8 ns |     3,510.12 ns |    10,183.49 ns |    164,200.0 ns |          - |     77632 B |
 SameValue  | 100    | Merge (Parallel) |    165,956.4 ns |     3,675.73 ns |    10,487.06 ns |    164,800.0 ns |          - |     77368 B |
 **Ascending**  | **100**    | **Selection**        |      **3,668.4 ns** |        **67.41 ns** |        **74.93 ns** |      **3,700.0 ns** |          **-** |       **544 B** |
 Descending | 100    | Selection        |      3,478.9 ns |        64.17 ns |        71.33 ns |      3,500.0 ns |          - |       544 B |
 Random     | 100    | Selection        |      5,969.6 ns |       120.24 ns |       152.06 ns |      6,000.0 ns |          - |       544 B |
 SameValue  | 100    | Selection        |      2,918.8 ns |        48.74 ns |        47.87 ns |      2,950.0 ns |          - |       544 B |
 **Ascending**  | **10000**  | **Insertion**        |     **48,080.0 ns** |       **681.19 ns** |       **637.18 ns** |     **48,000.0 ns** |          **-** |    **240520 B** |
 Descending | 10000  | Insertion        |     50,757.7 ns |     1,000.24 ns |     1,369.14 ns |     50,700.0 ns |          - |    240520 B |
 Random     | 10000  | Insertion        | 98,614,173.3 ns | 1,934,151.72 ns | 2,894,947.23 ns | 98,439,350.0 ns | 11000.0000 | 594634624 B |
 SameValue  | 10000  | Insertion        |     51,605.2 ns |     1,024.27 ns |     2,248.31 ns |     51,400.0 ns |          - |    240520 B |
 **Ascending**  | **10000**  | **Merge**            |    **245,169.2 ns** |     **2,177.85 ns** |     **1,818.60 ns** |    **244,700.0 ns** |          **-** |   **1072560 B** |
 Descending | 10000  | Merge            |    245,966.7 ns |     2,303.15 ns |     1,798.15 ns |    245,500.0 ns |          - |   1072560 B |
 Random     | 10000  | Merge            |    610,346.2 ns |     9,978.65 ns |     8,332.63 ns |    607,500.0 ns |          - |   1072560 B |
 SameValue  | 10000  | Merge            |    248,275.0 ns |     4,422.88 ns |     3,453.09 ns |    247,900.0 ns |          - |   1072560 B |
 **Ascending**  | **10000**  | **Merge (Async)**    |  **8,412,898.4 ns** |   **165,137.24 ns** |   **372,742.26 ns** |  **8,233,800.0 ns** |          **-** |   **2672400 B** |
 Descending | 10000  | Merge (Async)    |  9,121,341.7 ns |    37,034.40 ns |    28,914.02 ns |  9,115,950.0 ns |          - |   2672400 B |
 Random     | 10000  | Merge (Async)    |  8,870,790.0 ns |   170,993.28 ns |   345,414.86 ns |  8,700,350.0 ns |          - |   2672400 B |
 SameValue  | 10000  | Merge (Async)    |  9,015,969.8 ns |   246,719.82 ns |   711,843.10 ns |  8,823,900.0 ns |          - |   2672352 B |
 **Ascending**  | **10000**  | **Merge (Parallel)** | **19,768,543.0 ns** | **2,532,952.04 ns** | **7,468,466.23 ns** | **22,504,800.0 ns** |  **1000.0000** |  **59098376 B** |
 Descending | 10000  | Merge (Parallel) | 21,242,692.0 ns | 2,085,652.32 ns | 6,149,592.92 ns | 23,446,250.0 ns |  1000.0000 |  59135288 B |
 Random     | 10000  | Merge (Parallel) | 20,720,529.0 ns | 2,575,277.86 ns | 7,593,264.87 ns | 24,476,800.0 ns |          - |   7561184 B |
 SameValue  | 10000  | Merge (Parallel) | 18,046,640.0 ns | 2,148,971.09 ns | 6,336,289.75 ns | 13,301,250.0 ns |  1000.0000 |  59055696 B |
 **Ascending**  | **10000**  | **Selection**        | **31,674,140.0 ns** |   **582,834.45 ns** |   **671,193.02 ns** | **31,314,700.0 ns** |          **-** |       **496 B** |
 Descending | 10000  | Selection        | 31,351,573.3 ns |   530,943.74 ns |   496,645.11 ns | 31,119,600.0 ns |          - |       544 B |
 Random     | 10000  | Selection        | 26,871,190.0 ns |   525,374.32 ns |   605,021.84 ns | 26,793,650.0 ns |          - |       544 B |
 SameValue  | 10000  | Selection        | 25,444,010.3 ns |   366,576.65 ns |   537,323.30 ns | 25,279,300.0 ns |          - |       496 B |
