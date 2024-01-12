
BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
AMD Ryzen 7 7800X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-WZUDHU : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

 Method               | Times | Length | Mean | Error |
--------------------- |------ |------- |-----:|------:|
 **Add_SeparateChaining** | **1**     | **11**     |   **NA** |    **NA** |
 Add_LinearProbing    | 1     | 11     |   NA |    NA |
 Add_QuadraticProbing | 1     | 11     |   NA |    NA |
 **Add_SeparateChaining** | **5**     | **11**     |   **NA** |    **NA** |
 Add_LinearProbing    | 5     | 11     |   NA |    NA |
 Add_QuadraticProbing | 5     | 11     |   NA |    NA |
 **Add_SeparateChaining** | **10**    | **11**     |   **NA** |    **NA** |
 Add_LinearProbing    | 10    | 11     |   NA |    NA |
 Add_QuadraticProbing | 10    | 11     |   NA |    NA |

Benchmarks with issues:
  HashTableAddBenchmarks.Add_SeparateChaining: Job-WZUDHU(InvocationCount=1, UnrollFactor=1) [Times=1, Length=11]
  HashTableAddBenchmarks.Add_LinearProbing: Job-WZUDHU(InvocationCount=1, UnrollFactor=1) [Times=1, Length=11]
  HashTableAddBenchmarks.Add_QuadraticProbing: Job-WZUDHU(InvocationCount=1, UnrollFactor=1) [Times=1, Length=11]
  HashTableAddBenchmarks.Add_SeparateChaining: Job-WZUDHU(InvocationCount=1, UnrollFactor=1) [Times=5, Length=11]
  HashTableAddBenchmarks.Add_LinearProbing: Job-WZUDHU(InvocationCount=1, UnrollFactor=1) [Times=5, Length=11]
  HashTableAddBenchmarks.Add_QuadraticProbing: Job-WZUDHU(InvocationCount=1, UnrollFactor=1) [Times=5, Length=11]
  HashTableAddBenchmarks.Add_SeparateChaining: Job-WZUDHU(InvocationCount=1, UnrollFactor=1) [Times=10, Length=11]
  HashTableAddBenchmarks.Add_LinearProbing: Job-WZUDHU(InvocationCount=1, UnrollFactor=1) [Times=10, Length=11]
  HashTableAddBenchmarks.Add_QuadraticProbing: Job-WZUDHU(InvocationCount=1, UnrollFactor=1) [Times=10, Length=11]
