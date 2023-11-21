
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11370H 3.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-CVWMUC : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method                        | Length | Times | Mean          | Error       | StdDev        | Median        |
------------------------------ |------- |------ |--------------:|------------:|--------------:|--------------:|
 **Get_First_IndexOfLinearSearch** | **100**    | **1**     |    **29.2135 ns** |  **21.8991 ns** |    **60.6822 ns** |     **0.0000 ns** |
 Get_Mid_IndexOfLinearSearch   | 100    | 1     |   272.0000 ns |  63.2351 ns |   186.4501 ns |   200.0000 ns |
 Get_Last_IndexOfLinearSearch  | 100    | 1     |   180.6818 ns |  23.9052 ns |    65.8419 ns |   200.0000 ns |
 **Get_First_IndexOfLinearSearch** | **100**    | **10**    |   **198.0000 ns** |  **41.1808 ns** |   **121.4225 ns** |   **200.0000 ns** |
 Get_Mid_IndexOfLinearSearch   | 100    | 10    |   150.0000 ns |  23.5942 ns |    65.7711 ns |   100.0000 ns |
 Get_Last_IndexOfLinearSearch  | 100    | 10    |   203.4091 ns |  30.8708 ns |    85.0272 ns |   200.0000 ns |
 **Get_First_IndexOfLinearSearch** | **100**    | **100**   |     **0.0000 ns** |   **0.0000 ns** |     **0.0000 ns** |     **0.0000 ns** |
 Get_Mid_IndexOfLinearSearch   | 100    | 100   |   203.1250 ns |  48.3542 ns |   139.5128 ns |   200.0000 ns |
 Get_Last_IndexOfLinearSearch  | 100    | 100   |   190.8163 ns |  42.3698 ns |   123.5946 ns |   100.0000 ns |
 **Get_First_IndexOfLinearSearch** | **10000**  | **1**     |   **250.6494 ns** |  **44.5798 ns** |   **114.2750 ns** |   **200.0000 ns** |
 Get_Mid_IndexOfLinearSearch   | 10000  | 1     | 1,740.0000 ns | 290.0643 ns |   832.2489 ns | 1,400.0000 ns |
 Get_Last_IndexOfLinearSearch  | 10000  | 1     | 2,848.9583 ns | 371.0495 ns | 1,070.5625 ns | 2,500.0000 ns |
 **Get_First_IndexOfLinearSearch** | **10000**  | **10**    |   **315.5844 ns** |  **33.5256 ns** |    **85.9390 ns** |   **300.0000 ns** |
 Get_Mid_IndexOfLinearSearch   | 10000  | 10    | 1,895.9184 ns | 293.3297 ns |   855.6565 ns | 1,600.0000 ns |
 Get_Last_IndexOfLinearSearch  | 10000  | 10    | 2,553.2609 ns | 301.3666 ns |   850.0098 ns | 2,300.0000 ns |
 **Get_First_IndexOfLinearSearch** | **10000**  | **100**   |   **337.1795 ns** |  **47.2856 ns** |   **122.0591 ns** |   **350.0000 ns** |
 Get_Mid_IndexOfLinearSearch   | 10000  | 100   | 1,885.2632 ns | 328.0150 ns |   941.1365 ns | 1,500.0000 ns |
 Get_Last_IndexOfLinearSearch  | 10000  | 100   | 2,653.9326 ns | 318.6778 ns |   883.0546 ns | 2,400.0000 ns |
