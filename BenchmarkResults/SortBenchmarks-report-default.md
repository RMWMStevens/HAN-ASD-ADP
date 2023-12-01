
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-XFVTFR : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method     | Length | Algorithm | Mean             | Error           | StdDev          | Median          | Gen0       | Allocated   |
----------- |------- |---------- |-----------------:|----------------:|----------------:|----------------:|-----------:|------------:|
 **Ascending**  | **3**      | **Insertion** |        **600.00 ns** |        **56.07 ns** |       **159.97 ns** |        **550.0 ns** |          **-** |       **592 B** |
 Descending | 3      | Insertion |        525.61 ns |        25.70 ns |        68.15 ns |        500.0 ns |          - |       592 B |
 Random     | 3      | Insertion |        548.78 ns |        22.36 ns |        59.30 ns |        500.0 ns |          - |       592 B |
 SameValue  | 3      | Insertion |        659.60 ns |        61.60 ns |       180.66 ns |        600.0 ns |          - |       592 B |
 **Ascending**  | **3**      | **Selection** |         **87.06 ns** |        **12.49 ns** |        **33.76 ns** |        **100.0 ns** |          **-** |       **544 B** |
 Descending | 3      | Selection |         80.00 ns |        15.38 ns |        40.25 ns |        100.0 ns |          - |       544 B |
 Random     | 3      | Selection |        124.24 ns |        23.91 ns |        70.12 ns |        100.0 ns |          - |       544 B |
 SameValue  | 3      | Selection |        145.45 ns |        24.00 ns |        70.38 ns |        100.0 ns |          - |       544 B |
 **Ascending**  | **100**    | **Insertion** |        **984.62 ns** |        **24.24 ns** |        **62.58 ns** |      **1,000.0 ns** |          **-** |      **2920 B** |
 Descending | 100    | Insertion |      1,051.04 ns |        61.38 ns |       177.11 ns |      1,000.0 ns |          - |      2920 B |
 Random     | 100    | Insertion |     14,038.89 ns |       367.09 ns |     1,023.29 ns |     13,900.0 ns |          - |     62752 B |
 SameValue  | 100    | Insertion |      1,077.66 ns |        50.40 ns |       143.80 ns |      1,000.0 ns |          - |      2920 B |
 **Ascending**  | **100**    | **Selection** |      **3,552.63 ns** |        **69.49 ns** |        **77.23 ns** |      **3,500.0 ns** |          **-** |       **544 B** |
 Descending | 100    | Selection |      3,483.33 ns |        49.86 ns |        38.92 ns |      3,500.0 ns |          - |       544 B |
 Random     | 100    | Selection |      6,031.58 ns |       108.35 ns |       120.43 ns |      6,100.0 ns |          - |       544 B |
 SameValue  | 100    | Selection |      2,935.00 ns |        48.60 ns |        86.38 ns |      2,900.0 ns |          - |       544 B |
 **Ascending**  | **10000**  | **Insertion** |     **47,328.57 ns** |       **298.22 ns** |       **264.37 ns** |     **47,250.0 ns** |          **-** |    **240520 B** |
 Descending | 10000  | Insertion |     50,978.57 ns |       990.54 ns |       878.09 ns |     51,400.0 ns |          - |    240520 B |
 Random     | 10000  | Insertion | 93,269,533.33 ns | 1,788,849.44 ns | 2,677,465.62 ns | 93,538,700.0 ns | 11000.0000 | 599050216 B |
 SameValue  | 10000  | Insertion |     50,935.48 ns |     1,013.41 ns |     1,547.59 ns |     50,600.0 ns |          - |    240520 B |
 **Ascending**  | **10000**  | **Selection** | **30,758,506.78 ns** |   **613,920.73 ns** | **1,360,405.94 ns** | **31,098,100.0 ns** |          **-** |       **496 B** |
 Descending | 10000  | Selection | 31,316,380.00 ns |   229,374.32 ns |   214,556.88 ns | 31,220,300.0 ns |          - |       544 B |
 Random     | 10000  | Selection | 26,339,960.00 ns |   318,774.17 ns |   298,181.55 ns | 26,240,100.0 ns |          - |       544 B |
 SameValue  | 10000  | Selection | 25,028,650.00 ns |   256,857.63 ns |   227,697.60 ns | 24,935,500.0 ns |          - |       544 B |
