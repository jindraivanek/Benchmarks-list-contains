``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.3208)
12th Gen Intel Core i7-12800H, 1 CPU, 20 logical and 14 physical cores
.NET SDK=7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|                                  Method |        Mean |     Error |    StdDev |      Gen0 |  Allocated |
|---------------------------------------- |------------:|----------:|----------:|----------:|-----------:|
|                    &#39;int - Array.exists&#39; |    680.7 μs |   9.28 μs |   8.22 μs |         - |       33 B |
|                  &#39;int - Array.contains&#39; |    678.8 μs |   4.71 μs |   4.18 μs |         - |       33 B |
|          &#39;int - Array.containsByExists&#39; | 25,871.9 μs | 516.35 μs | 671.40 μs | 1906.2500 | 24024051 B |
|    &#39;int - Array.containsByExistsInline&#39; |    674.6 μs |   9.77 μs |   9.14 μs |         - |       33 B |
|                 &#39;string - Array.exists&#39; |  2,601.8 μs |  48.39 μs |  69.41 μs |         - |       34 B |
|               &#39;string - Array.contains&#39; |  2,531.9 μs |  50.01 μs |  53.51 μs |         - |       34 B |
|       &#39;string - Array.containsByExists&#39; |  6,809.1 μs |  96.07 μs |  85.16 μs |         - |       37 B |
| &#39;string - Array.containsByExistsInline&#39; |  2,508.0 μs |  47.43 μs |  44.37 μs |         - |       34 B |
|                 &#39;record - Array.exists&#39; |    788.1 μs |  12.45 μs |  11.03 μs |         - |       33 B |
|               &#39;record - Array.contains&#39; |    806.3 μs |  15.28 μs |  16.34 μs |         - |       33 B |
|       &#39;record - Array.containsByExists&#39; | 10,248.9 μs | 196.80 μs | 210.57 μs |         - |    24041 B |
| &#39;record - Array.containsByExistsInline&#39; |    802.7 μs |  15.17 μs |  14.19 μs |         - |       33 B |
