
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11370H 3.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-EILUBG : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                                 | Length | Times | Mean        | Error     | StdDev     | Median        |
--------------------------------------- |------- |------ |------------:|----------:|-----------:|--------------:|
 **Get_First_IndexOfLinearSearch**          | **100**    | **1**     |    **58.70 ns** | **34.125 ns** |  **96.251 ns** |     **0.0000 ns** |
 Get_Mid_IndexOfLinearSearch            | 100    | 1     |   193.81 ns | 57.551 ns | 166.967 ns |   200.0000 ns |
 Get_Last_IndexOfLinearSearch           | 100    | 1     |   251.02 ns | 55.745 ns | 162.611 ns |   200.0000 ns |
 Get_First_IndexOfBinarySearchRecursive | 100    | 1     |   225.27 ns | 24.704 ns |  69.271 ns |   200.0000 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 100    | 1     |   255.43 ns | 22.524 ns |  63.530 ns |   250.0000 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 100    | 1     |   336.00 ns | 53.358 ns | 157.326 ns |   300.0000 ns |
 **Get_First_IndexOfLinearSearch**          | **100**    | **10**    |    **35.05 ns** | **21.710 ns** |  **62.984 ns** |     **0.0000 ns** |
 Get_Mid_IndexOfLinearSearch            | 100    | 10    |   194.00 ns | 41.974 ns | 123.763 ns |   100.0000 ns |
 Get_Last_IndexOfLinearSearch           | 100    | 10    |   143.16 ns | 20.113 ns |  57.709 ns |   100.0000 ns |
 Get_First_IndexOfBinarySearchRecursive | 100    | 10    |   176.51 ns | 24.184 ns |  64.552 ns |   150.0000 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 100    | 10    |   186.67 ns | 13.542 ns |  34.222 ns |   200.0000 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 100    | 10    |   200.00 ns |  0.000 ns |   0.000 ns |   200.0000 ns |
 **Get_First_IndexOfLinearSearch**          | **100**    | **100**   |   **137.76 ns** | **40.071 ns** | **116.889 ns** |    **50.0000 ns** |
 Get_Mid_IndexOfLinearSearch            | 100    | 100   |   177.66 ns | 32.974 ns |  94.076 ns |   150.0000 ns |
 Get_Last_IndexOfLinearSearch           | 100    | 100   |   169.62 ns | 17.807 ns |  46.283 ns |   200.0000 ns |
 Get_First_IndexOfBinarySearchRecursive | 100    | 100   |   219.54 ns | 29.393 ns |  80.462 ns |   200.0000 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 100    | 100   |   134.88 ns | 26.306 ns |  71.566 ns |   100.0000 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 100    | 100   |   239.08 ns | 22.530 ns |  61.675 ns |   200.0000 ns |
 **Get_First_IndexOfLinearSearch**          | **10000**  | **1**     |   **151.04 ns** | **23.042 ns** |  **66.483 ns** |   **100.0000 ns** |
 Get_Mid_IndexOfLinearSearch            | 10000  | 1     |   965.52 ns | 49.460 ns | 135.396 ns |   900.0000 ns |
 Get_Last_IndexOfLinearSearch           | 10000  | 1     | 1,558.86 ns | 33.851 ns |  87.983 ns | 1,550.0000 ns |
 Get_First_IndexOfBinarySearchRecursive | 10000  | 1     |   308.05 ns | 29.592 ns |  81.009 ns |   300.0000 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 10000  | 1     |   248.35 ns | 20.147 ns |  56.495 ns |   200.0000 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 10000  | 1     |   273.33 ns | 17.617 ns |  44.519 ns |   300.0000 ns |
 **Get_First_IndexOfLinearSearch**          | **10000**  | **10**    |   **175.82 ns** | **27.284 ns** |  **76.508 ns** |   **200.0000 ns** |
 Get_Mid_IndexOfLinearSearch            | 10000  | 10    |   868.83 ns | 19.257 ns |  49.364 ns |   900.0000 ns |
 Get_Last_IndexOfLinearSearch           | 10000  | 10    | 1,528.21 ns | 31.948 ns |  55.954 ns | 1,500.0000 ns |
 Get_First_IndexOfBinarySearchRecursive | 10000  | 10    |   274.16 ns | 15.888 ns |  44.025 ns |   300.0000 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 10000  | 10    |   344.58 ns | 24.303 ns |  64.869 ns |   300.0000 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 10000  | 10    |   285.71 ns | 13.741 ns |  35.222 ns |   300.0000 ns |
 **Get_First_IndexOfLinearSearch**          | **10000**  | **100**   |   **146.46 ns** | **24.018 ns** |  **70.440 ns** |   **100.0000 ns** |
 Get_Mid_IndexOfLinearSearch            | 10000  | 100   |   861.70 ns | 23.048 ns |  65.757 ns |   900.0000 ns |
 Get_Last_IndexOfLinearSearch           | 10000  | 100   | 1,539.71 ns | 31.548 ns |  75.587 ns | 1,500.0000 ns |
 Get_First_IndexOfBinarySearchRecursive | 10000  | 100   |   275.53 ns | 19.015 ns |  54.252 ns |   300.0000 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 10000  | 100   |   323.33 ns | 25.252 ns |  70.392 ns |   300.0000 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 10000  | 100   |   318.52 ns | 26.238 ns |  69.121 ns |   300.0000 ns |
