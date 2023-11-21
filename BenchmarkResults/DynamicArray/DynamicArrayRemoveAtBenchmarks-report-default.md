
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-FJSBUM : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                     | Times | Length  | Mean             | Error         | StdDev          | Median             | Gen0      | Gen1      | Gen2      | Allocated  |
--------------------------- |------ |-------- |-----------------:|--------------:|----------------:|-------------------:|----------:|----------:|----------:|-----------:|
 **RemoveAt_First**             | **1**     | **100**     |        **133.00 ns** |      **21.59 ns** |        **63.65 ns** |        **100.0000 ns** |         **-** |         **-** |         **-** |      **544 B** |
 RemoveAt_Mid               | 1     | 100     |        117.00 ns |      23.64 ns |        69.71 ns |        100.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_Last              | 1     | 100     |         62.00 ns |      18.53 ns |        54.64 ns |        100.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_AlwaysResizeFirst | 1     | 100     |        642.00 ns |      47.28 ns |       139.39 ns |        600.0000 ns |         - |         - |         - |     1080 B |
 RemoveAt_AlwaysResizeMid   | 1     | 100     |        690.00 ns |      53.79 ns |       158.59 ns |        700.0000 ns |         - |         - |         - |     1080 B |
 RemoveAt_AlwaysResizeLast  | 1     | 100     |        514.43 ns |      52.65 ns |       152.75 ns |        500.0000 ns |         - |         - |         - |     1080 B |
 **RemoveAt_First**             | **1**     | **10000**   |      **5,072.41 ns** |     **140.23 ns** |       **383.89 ns** |      **4,900.0000 ns** |         **-** |         **-** |         **-** |      **544 B** |
 RemoveAt_Mid               | 1     | 10000   |      2,585.88 ns |     100.68 ns |       272.18 ns |      2,500.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_Last              | 1     | 10000   |         69.00 ns |      21.39 ns |        63.08 ns |        100.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_AlwaysResizeFirst | 1     | 10000   |      9,857.78 ns |     169.01 ns |       321.56 ns |      9,800.0000 ns |         - |         - |         - |    66104 B |
 RemoveAt_AlwaysResizeMid   | 1     | 10000   |      8,143.30 ns |     388.18 ns |     1,126.19 ns |      7,600.0000 ns |         - |         - |         - |    66104 B |
 RemoveAt_AlwaysResizeLast  | 1     | 10000   |      5,181.82 ns |     102.50 ns |       125.87 ns |      5,150.0000 ns |         - |         - |         - |    66104 B |
 **RemoveAt_First**             | **1**     | **1000000** |    **475,541.67 ns** |   **8,707.26 ns** |     **6,798.06 ns** |    **475,150.0000 ns** |         **-** |         **-** |         **-** |      **544 B** |
 RemoveAt_Mid               | 1     | 1000000 |    233,133.33 ns |   2,517.25 ns |     1,965.31 ns |    232,650.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_Last              | 1     | 1000000 |         72.73 ns |      17.49 ns |        44.83 ns |        100.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_AlwaysResizeFirst | 1     | 1000000 |  1,928,513.33 ns |  32,001.13 ns |    47,897.78 ns |  1,924,550.0000 ns |         - |         - |         - |  4194872 B |
 RemoveAt_AlwaysResizeMid   | 1     | 1000000 |  1,657,246.15 ns |  31,032.25 ns |    25,913.34 ns |  1,661,900.0000 ns |         - |         - |         - |  4194872 B |
 RemoveAt_AlwaysResizeLast  | 1     | 1000000 |  1,382,606.12 ns |  47,464.36 ns |   138,455.78 ns |  1,438,800.0000 ns |         - |         - |         - |  4194872 B |
 **RemoveAt_First**             | **5**     | **100**     |        **378.79 ns** |      **22.99 ns** |        **67.42 ns** |        **400.0000 ns** |         **-** |         **-** |         **-** |      **544 B** |
 RemoveAt_Mid               | 5     | 100     |        274.23 ns |      24.00 ns |        69.64 ns |        300.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_Last              | 5     | 100     |         43.00 ns |      21.15 ns |        62.37 ns |          0.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_AlwaysResizeFirst | 5     | 100     |        907.50 ns |      27.04 ns |        70.76 ns |        900.0000 ns |         - |         - |         - |     3176 B |
 RemoveAt_AlwaysResizeMid   | 5     | 100     |        860.42 ns |      58.32 ns |       168.26 ns |        800.0000 ns |         - |         - |         - |     3176 B |
 RemoveAt_AlwaysResizeLast  | 5     | 100     |        578.00 ns |      42.73 ns |       126.00 ns |        550.0000 ns |         - |         - |         - |     1080 B |
 **RemoveAt_First**             | **5**     | **10000**   |     **22,571.43 ns** |     **432.23 ns** |       **383.16 ns** |     **22,650.0000 ns** |         **-** |         **-** |         **-** |      **544 B** |
 RemoveAt_Mid               | 5     | 10000   |     11,621.43 ns |     183.39 ns |       162.57 ns |     11,600.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_Last              | 5     | 10000   |         83.53 ns |      13.80 ns |        37.31 ns |        100.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_AlwaysResizeFirst | 5     | 10000   |     47,760.00 ns |     265.72 ns |       354.73 ns |     47,800.0000 ns |         - |         - |         - |   328296 B |
 RemoveAt_AlwaysResizeMid   | 5     | 10000   |     36,641.67 ns |     286.19 ns |       223.44 ns |     36,750.0000 ns |         - |         - |         - |   328296 B |
 RemoveAt_AlwaysResizeLast  | 5     | 10000   |      5,058.06 ns |      96.79 ns |       147.82 ns |      5,000.0000 ns |         - |         - |         - |    66104 B |
 **RemoveAt_First**             | **5**     | **1000000** |  **2,367,600.00 ns** |  **25,487.16 ns** |    **21,282.94 ns** |  **2,362,400.0000 ns** |         **-** |         **-** |         **-** |      **544 B** |
 RemoveAt_Mid               | 5     | 1000000 |  1,184,461.54 ns |  13,459.01 ns |    11,238.89 ns |  1,183,300.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_Last              | 5     | 1000000 |        117.53 ns |      23.87 ns |        69.24 ns |        100.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_AlwaysResizeFirst | 5     | 1000000 |  9,987,807.45 ns | 284,412.23 ns |   811,444.11 ns | 10,288,600.0000 ns | 1000.0000 | 1000.0000 | 1000.0000 | 20972400 B |
 RemoveAt_AlwaysResizeMid   | 5     | 1000000 |  9,324,261.54 ns | 159,606.73 ns |   133,278.85 ns |  9,319,300.0000 ns | 1000.0000 | 1000.0000 | 1000.0000 | 20972448 B |
 RemoveAt_AlwaysResizeLast  | 5     | 1000000 |  1,447,016.67 ns |  18,842.95 ns |    14,711.33 ns |  1,451,750.0000 ns |         - |         - |         - |  4194872 B |
 **RemoveAt_First**             | **10**    | **100**     |        **555.81 ns** |      **21.55 ns** |        **58.62 ns** |        **600.0000 ns** |         **-** |         **-** |         **-** |      **544 B** |
 RemoveAt_Mid               | 10    | 100     |        355.32 ns |      26.52 ns |        75.66 ns |        300.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_Last              | 10    | 100     |         40.40 ns |      18.81 ns |        55.18 ns |          0.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_AlwaysResizeFirst | 10    | 100     |      1,372.09 ns |      29.65 ns |        80.66 ns |      1,400.0000 ns |         - |         - |         - |     5704 B |
 RemoveAt_AlwaysResizeMid   | 10    | 100     |      1,467.35 ns |     124.80 ns |       364.05 ns |      1,300.0000 ns |         - |         - |         - |     5704 B |
 RemoveAt_AlwaysResizeLast  | 10    | 100     |        429.76 ns |      22.21 ns |        59.68 ns |        400.0000 ns |         - |         - |         - |     1080 B |
 **RemoveAt_First**             | **10**    | **10000**   |     **46,157.14 ns** |     **588.18 ns** |       **521.41 ns** |     **46,100.0000 ns** |         **-** |         **-** |         **-** |      **544 B** |
 RemoveAt_Mid               | 10    | 10000   |     22,989.47 ns |     315.81 ns |       351.02 ns |     23,100.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_Last              | 10    | 10000   |         33.00 ns |      17.42 ns |        51.36 ns |          0.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_AlwaysResizeFirst | 10    | 10000   |     94,216.67 ns |     738.49 ns |       576.56 ns |     94,100.0000 ns |         - |         - |         - |   655944 B |
 RemoveAt_AlwaysResizeMid   | 10    | 10000   |     72,069.23 ns |     404.29 ns |       337.60 ns |     72,100.0000 ns |         - |         - |         - |   655944 B |
 RemoveAt_AlwaysResizeLast  | 10    | 10000   |      5,094.44 ns |      94.85 ns |       158.46 ns |      5,050.0000 ns |         - |         - |         - |    66104 B |
 **RemoveAt_First**             | **10**    | **1000000** |  **4,764,976.92 ns** |  **78,848.14 ns** |    **65,841.77 ns** |  **4,785,100.0000 ns** |         **-** |         **-** |         **-** |      **544 B** |
 RemoveAt_Mid               | 10    | 1000000 |  2,374,361.54 ns |  36,998.57 ns |    30,895.48 ns |  2,372,000.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_Last              | 10    | 1000000 |        111.22 ns |      27.36 ns |        79.80 ns |        100.0000 ns |         - |         - |         - |      544 B |
 RemoveAt_AlwaysResizeFirst | 10    | 1000000 | 17,114,485.00 ns | 469,323.65 ns | 1,383,811.38 ns | 16,682,550.0000 ns | 2000.0000 | 2000.0000 | 2000.0000 | 41944200 B |
 RemoveAt_AlwaysResizeMid   | 10    | 1000000 | 14,963,691.00 ns | 452,768.82 ns | 1,334,999.08 ns | 14,441,350.0000 ns | 2000.0000 | 2000.0000 | 2000.0000 | 41944200 B |
 RemoveAt_AlwaysResizeLast  | 10    | 1000000 |  1,448,458.33 ns |  21,093.79 ns |    27,427.88 ns |  1,441,600.0000 ns |         - |         - |         - |  4194872 B |
