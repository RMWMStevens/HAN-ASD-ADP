
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-FJSBUM : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                                 | Length | Times | Mean       | Error    | StdDev    | Median     |
--------------------------------------- |------- |------ |-----------:|---------:|----------:|-----------:|
 **Get_First_IndexOfLinearSearch**          | **100**    | **1**     |   **174.7 ns** | **23.83 ns** |  **68.37 ns** |   **200.0 ns** |
 Get_Mid_IndexOfLinearSearch            | 100    | 1     |   263.3 ns | 23.29 ns |  67.94 ns |   300.0 ns |
 Get_Last_IndexOfLinearSearch           | 100    | 1     |   249.0 ns | 24.73 ns |  72.15 ns |   200.0 ns |
 Get_First_IndexOfBinarySearchRecursive | 100    | 1     |   174.1 ns | 16.74 ns |  44.10 ns |   200.0 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 100    | 1     |   247.4 ns | 26.34 ns |  75.57 ns |   200.0 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 100    | 1     |   232.3 ns | 29.10 ns |  83.97 ns |   200.0 ns |
 **Get_First_IndexOfLinearSearch**          | **100**    | **10**    |   **177.9 ns** | **21.68 ns** |  **62.19 ns** |   **200.0 ns** |
 Get_Mid_IndexOfLinearSearch            | 100    | 10    |   241.0 ns | 31.65 ns |  93.31 ns |   200.0 ns |
 Get_Last_IndexOfLinearSearch           | 100    | 10    |   200.0 ns |  0.00 ns |   0.00 ns |   200.0 ns |
 Get_First_IndexOfBinarySearchRecursive | 100    | 10    |   175.9 ns | 16.55 ns |  43.01 ns |   200.0 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 100    | 10    |   248.9 ns | 24.20 ns |  67.45 ns |   200.0 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 100    | 10    |   170.6 ns | 16.95 ns |  45.83 ns |   200.0 ns |
 **Get_First_IndexOfLinearSearch**          | **100**    | **100**   |   **189.4 ns** | **23.25 ns** |  **66.35 ns** |   **200.0 ns** |
 Get_Mid_IndexOfLinearSearch            | 100    | 100   |   260.0 ns | 26.84 ns |  79.14 ns |   200.0 ns |
 Get_Last_IndexOfLinearSearch           | 100    | 100   |   250.0 ns | 23.05 ns |  66.49 ns |   200.0 ns |
 Get_First_IndexOfBinarySearchRecursive | 100    | 100   |   212.9 ns | 27.61 ns |  78.33 ns |   200.0 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 100    | 100   |   174.7 ns | 17.33 ns |  43.78 ns |   200.0 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 100    | 100   |   172.0 ns | 17.89 ns |  45.20 ns |   200.0 ns |
 **Get_First_IndexOfLinearSearch**          | **10000**  | **1**     |   **168.4 ns** | **24.90 ns** |  **72.65 ns** |   **200.0 ns** |
 Get_Mid_IndexOfLinearSearch            | 10000  | 1     |   829.6 ns | 18.44 ns |  48.59 ns |   800.0 ns |
 Get_Last_IndexOfLinearSearch           | 10000  | 1     | 1,400.0 ns |  0.00 ns |   0.00 ns | 1,400.0 ns |
 Get_First_IndexOfBinarySearchRecursive | 10000  | 1     |   249.5 ns | 23.02 ns |  65.31 ns |   200.0 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 10000  | 1     |   300.0 ns |  0.00 ns |   0.00 ns |   300.0 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 10000  | 1     |   321.6 ns | 28.24 ns |  81.94 ns |   300.0 ns |
 **Get_First_IndexOfLinearSearch**          | **10000**  | **10**    |   **177.6 ns** | **15.50 ns** |  **41.91 ns** |   **200.0 ns** |
 Get_Mid_IndexOfLinearSearch            | 10000  | 10    |   867.0 ns | 33.36 ns |  91.88 ns |   800.0 ns |
 Get_Last_IndexOfLinearSearch           | 10000  | 10    | 1,442.4 ns | 30.74 ns |  72.45 ns | 1,400.0 ns |
 Get_First_IndexOfBinarySearchRecursive | 10000  | 10    |   295.8 ns | 28.85 ns |  83.25 ns |   300.0 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 10000  | 10    |   278.7 ns | 24.62 ns |  68.21 ns |   300.0 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 10000  | 10    |   311.7 ns | 28.09 ns |  80.13 ns |   300.0 ns |
 **Get_First_IndexOfLinearSearch**          | **10000**  | **100**   |   **185.4 ns** | **13.41 ns** |  **35.56 ns** |   **200.0 ns** |
 Get_Mid_IndexOfLinearSearch            | 10000  | 100   |   824.7 ns | 23.26 ns |  64.46 ns |   800.0 ns |
 Get_Last_IndexOfLinearSearch           | 10000  | 100   | 1,407.0 ns | 29.77 ns |  55.19 ns | 1,400.0 ns |
 Get_First_IndexOfBinarySearchRecursive | 10000  | 100   |   255.9 ns | 22.93 ns |  65.05 ns |   200.0 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 10000  | 100   |   302.0 ns | 37.48 ns | 109.34 ns |   300.0 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 10000  | 100   |   276.2 ns | 16.36 ns |  42.82 ns |   300.0 ns |
