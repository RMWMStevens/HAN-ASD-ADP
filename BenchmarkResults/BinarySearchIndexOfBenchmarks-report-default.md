
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-IAKMNO : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                                 | Length | Times | Mean        | Error     | StdDev    | Median        |
--------------------------------------- |------- |------ |------------:|----------:|----------:|--------------:|
 **Get_First_IndexOfLinearSearch**          | **100**    | **1**     |    **32.00 ns** | **18.595 ns** |  **54.83 ns** |     **0.0000 ns** |
 Get_Mid_IndexOfLinearSearch            | 100    | 1     |   155.10 ns | 21.526 ns |  62.79 ns |   100.0000 ns |
 Get_Last_IndexOfLinearSearch           | 100    | 1     |   154.55 ns | 20.822 ns |  61.07 ns |   100.0000 ns |
 Get_First_IndexOfBinarySearchRecursive | 100    | 1     |   216.00 ns | 35.983 ns | 106.10 ns |   200.0000 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 100    | 1     |   300.00 ns | 31.976 ns |  94.28 ns |   300.0000 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 100    | 1     |   269.00 ns | 35.651 ns | 105.12 ns |   200.0000 ns |
 **Get_First_IndexOfLinearSearch**          | **100**    | **10**    |    **54.55 ns** | **21.384 ns** |  **62.72 ns** |     **0.0000 ns** |
 Get_Mid_IndexOfLinearSearch            | 100    | 10    |   133.00 ns | 23.643 ns |  69.71 ns |   100.0000 ns |
 Get_Last_IndexOfLinearSearch           | 100    | 10    |   170.00 ns | 21.826 ns |  64.35 ns |   200.0000 ns |
 Get_First_IndexOfBinarySearchRecursive | 100    | 10    |   276.00 ns | 26.891 ns |  79.29 ns |   300.0000 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 100    | 10    |   268.82 ns | 25.451 ns |  72.20 ns |   300.0000 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 100    | 10    |   231.31 ns | 28.254 ns |  82.87 ns |   200.0000 ns |
 **Get_First_IndexOfLinearSearch**          | **100**    | **100**   |    **70.00 ns** | **21.287 ns** |  **62.76 ns** |   **100.0000 ns** |
 Get_Mid_IndexOfLinearSearch            | 100    | 100   |   137.37 ns | 22.631 ns |  66.37 ns |   100.0000 ns |
 Get_Last_IndexOfLinearSearch           | 100    | 100   |   178.00 ns | 21.330 ns |  62.89 ns |   200.0000 ns |
 Get_First_IndexOfBinarySearchRecursive | 100    | 100   |   222.45 ns | 40.750 ns | 118.87 ns |   200.0000 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 100    | 100   |   239.78 ns | 30.368 ns |  86.15 ns |   200.0000 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 100    | 100   |   227.84 ns | 25.242 ns |  73.23 ns |   200.0000 ns |
 **Get_First_IndexOfLinearSearch**          | **10000**  | **1**     |    **73.68 ns** | **15.429 ns** |  **44.27 ns** |   **100.0000 ns** |
 Get_Mid_IndexOfLinearSearch            | 10000  | 1     | 2,182.76 ns | 44.918 ns |  65.84 ns | 2,200.0000 ns |
 Get_Last_IndexOfLinearSearch           | 10000  | 1     | 4,226.67 ns | 63.461 ns |  59.36 ns | 4,200.0000 ns |
 Get_First_IndexOfBinarySearchRecursive | 10000  | 1     |   267.05 ns | 24.446 ns |  67.33 ns |   300.0000 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 10000  | 1     |   312.90 ns | 30.847 ns |  87.51 ns |   300.0000 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 10000  | 1     |   342.71 ns | 28.334 ns |  81.75 ns |   300.0000 ns |
 **Get_First_IndexOfLinearSearch**          | **10000**  | **10**    |    **36.93 ns** |  **8.022 ns** |  **22.09 ns** |    **50.0000 ns** |
 Get_Mid_IndexOfLinearSearch            | 10000  | 10    | 2,160.00 ns | 43.646 ns |  50.26 ns | 2,200.0000 ns |
 Get_Last_IndexOfLinearSearch           | 10000  | 10    | 4,200.00 ns | 61.553 ns |  75.59 ns | 4,200.0000 ns |
 Get_First_IndexOfBinarySearchRecursive | 10000  | 10    |   245.05 ns | 25.084 ns |  70.34 ns |   200.0000 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 10000  | 10    |   342.27 ns | 28.508 ns |  82.71 ns |   300.0000 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 10000  | 10    |   282.98 ns | 23.910 ns |  68.22 ns |   300.0000 ns |
 **Get_First_IndexOfLinearSearch**          | **10000**  | **100**   |    **48.00 ns** | **19.569 ns** |  **57.70 ns** |     **0.0000 ns** |
 Get_Mid_IndexOfLinearSearch            | 10000  | 100   | 2,155.00 ns | 44.322 ns |  51.04 ns | 2,200.0000 ns |
 Get_Last_IndexOfLinearSearch           | 10000  | 100   | 4,169.23 ns | 57.528 ns |  48.04 ns | 4,200.0000 ns |
 Get_First_IndexOfBinarySearchRecursive | 10000  | 100   |   263.04 ns | 27.168 ns |  76.63 ns |   200.0000 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 10000  | 100   |   324.24 ns | 24.399 ns |  71.56 ns |   300.0000 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 10000  | 100   |   272.62 ns | 16.698 ns |  44.86 ns |   300.0000 ns |
