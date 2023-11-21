
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11370H 3.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-TIKTND : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                                 | Length | Times | Mean        | Error        | StdDev       | Median      |
--------------------------------------- |------- |------ |------------:|-------------:|-------------:|------------:|
 **Get_First_IndexOfLinearSearch**          | **100**    | **1**     |    **94.12 ns** |     **8.755 ns** |    **23.669 ns** |   **100.00 ns** |
 Get_Mid_IndexOfLinearSearch            | 100    | 1     |   119.39 ns |    46.350 ns |   135.204 ns |   100.00 ns |
 Get_Last_IndexOfLinearSearch           | 100    | 1     |   163.58 ns |    29.252 ns |    77.060 ns |   150.00 ns |
 Get_First_IndexOfBinarySearchRecursive | 100    | 1     |   122.09 ns |    31.088 ns |    84.577 ns |   100.00 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 100    | 1     |    81.32 ns |    30.498 ns |    85.521 ns |   100.00 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 100    | 1     |   363.64 ns |    59.548 ns |   174.645 ns |   300.00 ns |
 **Get_First_IndexOfLinearSearch**          | **100**    | **10**    |    **64.13 ns** |    **25.524 ns** |    **71.991 ns** |    **50.00 ns** |
 Get_Mid_IndexOfLinearSearch            | 100    | 10    |   194.90 ns |    43.299 ns |   126.306 ns |   100.00 ns |
 Get_Last_IndexOfLinearSearch           | 100    | 10    |   103.33 ns |    44.491 ns |   124.024 ns |   100.00 ns |
 Get_First_IndexOfBinarySearchRecursive | 100    | 10    |   214.29 ns |    50.441 ns |   147.138 ns |   200.00 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 100    | 10    |   115.31 ns |    43.293 ns |   126.289 ns |   100.00 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 100    | 10    |   178.89 ns |    24.786 ns |    69.094 ns |   150.00 ns |
 **Get_First_IndexOfLinearSearch**          | **100**    | **100**   |   **109.28 ns** |    **44.522 ns** |   **129.166 ns** |   **100.00 ns** |
 Get_Mid_IndexOfLinearSearch            | 100    | 100   |   200.00 ns |     0.000 ns |     0.000 ns |   200.00 ns |
 Get_Last_IndexOfLinearSearch           | 100    | 100   |    79.55 ns |    23.458 ns |    64.610 ns |   100.00 ns |
 Get_First_IndexOfBinarySearchRecursive | 100    | 100   |   245.45 ns |    48.532 ns |   142.337 ns |   200.00 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 100    | 100   |   259.18 ns |    55.438 ns |   161.716 ns |   300.00 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 100    | 100   |   300.00 ns |    58.656 ns |   170.171 ns |   300.00 ns |
 **Get_First_IndexOfLinearSearch**          | **10000**  | **1**     |   **183.33 ns** |    **46.478 ns** |   **119.975 ns** |   **200.00 ns** |
 Get_Mid_IndexOfLinearSearch            | 10000  | 1     | 2,535.42 ns |   602.230 ns | 1,737.571 ns | 1,700.00 ns |
 Get_Last_IndexOfLinearSearch           | 10000  | 1     | 5,064.65 ns | 1,329.421 ns | 3,898.961 ns | 3,200.00 ns |
 Get_First_IndexOfBinarySearchRecursive | 10000  | 1     |   693.88 ns |   138.865 ns |   405.075 ns |   500.00 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 10000  | 1     |   311.39 ns |    55.784 ns |   144.991 ns |   300.00 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 10000  | 1     |   783.84 ns |   147.801 ns |   433.474 ns |   600.00 ns |
 **Get_First_IndexOfLinearSearch**          | **10000**  | **10**    |   **185.53 ns** |    **43.373 ns** |   **110.398 ns** |   **200.00 ns** |
 Get_Mid_IndexOfLinearSearch            | 10000  | 10    | 2,972.00 ns |   696.344 ns | 2,053.186 ns | 1,800.00 ns |
 Get_Last_IndexOfLinearSearch           | 10000  | 10    | 5,005.10 ns | 1,353.733 ns | 3,948.904 ns | 2,900.00 ns |
 Get_First_IndexOfBinarySearchRecursive | 10000  | 10    |   630.93 ns |   121.087 ns |   351.295 ns |   500.00 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 10000  | 10    |   441.03 ns |    93.117 ns |   240.365 ns |   400.00 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 10000  | 10    |   922.22 ns |   142.142 ns |   416.877 ns |   900.00 ns |
 **Get_First_IndexOfLinearSearch**          | **10000**  | **100**   |   **325.32 ns** |    **49.893 ns** |   **127.894 ns** |   **350.00 ns** |
 Get_Mid_IndexOfLinearSearch            | 10000  | 100   | 4,387.00 ns |   759.267 ns | 2,238.716 ns | 5,550.00 ns |
 Get_Last_IndexOfLinearSearch           | 10000  | 100   | 6,476.00 ns | 1,452.763 ns | 4,283.504 ns | 4,100.00 ns |
 Get_First_IndexOfBinarySearchRecursive | 10000  | 100   |   646.81 ns |   131.719 ns |   375.801 ns |   500.00 ns |
 Get_Mid_IndexOfBinarySearchRecursive   | 10000  | 100   |   349.37 ns |    66.604 ns |   173.111 ns |   300.00 ns |
 Get_Last_IndexOfBinarySearchRecursive  | 10000  | 100   |   847.37 ns |   158.241 ns |   454.023 ns |   800.00 ns |
