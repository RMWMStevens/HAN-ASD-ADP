
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2715/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WBRHZI : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method    | Size    | Mean      | Error     | StdDev   | Median      | Allocated |
---------- |-------- |----------:|----------:|---------:|------------:|----------:|
 **Get_First** | **1**       |  **43.00 ns** | **19.435 ns** | **57.30 ns** |   **0.0000 ns** |     **544 B** |
 Get_Mid   | 1       |  57.00 ns | 21.153 ns | 62.37 ns |  50.0000 ns |     544 B |
 Get_Last  | 1       |  50.00 ns | 19.581 ns | 57.74 ns |   0.0000 ns |     544 B |
 **Get_First** | **10**      |  **60.00 ns** | **19.282 ns** | **56.85 ns** | **100.0000 ns** |     **544 B** |
 Get_Mid   | 10      |  61.00 ns | 20.954 ns | 61.78 ns | 100.0000 ns |     544 B |
 Get_Last  | 10      |  75.76 ns | 21.833 ns | 64.03 ns | 100.0000 ns |     544 B |
 **Get_First** | **100**     |  **53.00 ns** | **18.951 ns** | **55.88 ns** |  **50.0000 ns** |     **544 B** |
 Get_Mid   | 100     |  61.00 ns | 19.814 ns | 58.42 ns | 100.0000 ns |     544 B |
 Get_Last  | 100     |  35.35 ns | 18.428 ns | 54.05 ns |   0.0000 ns |     544 B |
 **Get_First** | **1000**    |  **52.00 ns** | **18.966 ns** | **55.92 ns** |   **0.0000 ns** |     **544 B** |
 Get_Mid   | 1000    |  72.00 ns | 22.132 ns | 65.26 ns | 100.0000 ns |     544 B |
 Get_Last  | 1000    |  44.90 ns | 20.955 ns | 61.13 ns |   0.0000 ns |     544 B |
 **Get_First** | **10000**   |  **65.00 ns** | **20.093 ns** | **59.25 ns** | **100.0000 ns** |     **544 B** |
 Get_Mid   | 10000   |  46.00 ns | 20.119 ns | 59.32 ns |   0.0000 ns |     544 B |
 Get_Last  | 10000   |  62.00 ns | 19.149 ns | 56.46 ns | 100.0000 ns |     544 B |
 **Get_First** | **100000**  |  **65.26 ns** | **22.604 ns** | **64.85 ns** | **100.0000 ns** |     **544 B** |
 Get_Mid   | 100000  |  83.84 ns | 20.497 ns | 60.11 ns | 100.0000 ns |     544 B |
 Get_Last  | 100000  |  65.00 ns | 19.507 ns | 57.52 ns | 100.0000 ns |     544 B |
 **Get_First** | **1000000** | **129.59 ns** | **21.574 ns** | **62.93 ns** | **100.0000 ns** |     **544 B** |
 Get_Mid   | 1000000 |  37.65 ns |  8.235 ns | 21.70 ns |  50.0000 ns |     544 B |
 Get_Last  | 1000000 |  73.49 ns | 16.636 ns | 44.40 ns | 100.0000 ns |     544 B |
