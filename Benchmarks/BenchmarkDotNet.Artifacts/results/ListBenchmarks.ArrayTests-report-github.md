``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.3208)
12th Gen Intel Core i7-12800H, 1 CPU, 20 logical and 14 physical cores
.NET SDK=8.0.100-preview.6.23330.14
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|                                  Method |       Mean |     Error |    StdDev |     Median |      Gen0 |  Allocated |
|---------------------------------------- |-----------:|----------:|----------:|-----------:|----------:|-----------:|
|                    &#39;int - Array.exists&#39; |   228.6 μs |   4.51 μs |   4.63 μs |   228.2 μs |         - |       32 B |
|                  &#39;int - Array.contains&#39; |   225.5 μs |   1.20 μs |   1.12 μs |   225.7 μs |         - |       32 B |
|          &#39;int - Array.containsByExists&#39; | 9,042.9 μs | 180.68 μs | 469.61 μs | 9,007.2 μs | 1906.2500 | 24024041 B |
|    &#39;int - Array.containsByExistsInline&#39; |   226.1 μs |   3.26 μs |   3.05 μs |   225.4 μs |         - |       32 B |
|                 &#39;string - Array.exists&#39; |   929.8 μs |  17.92 μs |  25.70 μs |   930.6 μs |         - |       33 B |
|               &#39;string - Array.contains&#39; |   844.1 μs |  16.37 μs |  20.71 μs |   838.1 μs |         - |       33 B |
|       &#39;string - Array.containsByExists&#39; | 2,123.0 μs |  11.77 μs |  11.01 μs | 2,125.9 μs |         - |       34 B |
| &#39;string - Array.containsByExistsInline&#39; |   811.2 μs |   6.56 μs |   6.14 μs |   809.3 μs |         - |       33 B |
|                 &#39;record - Array.exists&#39; |   256.5 μs |   2.34 μs |   2.19 μs |   256.4 μs |         - |       32 B |
|               &#39;record - Array.contains&#39; |   288.4 μs |   5.59 μs |   7.83 μs |   283.7 μs |         - |       32 B |
|       &#39;record - Array.containsByExists&#39; | 3,529.8 μs |  34.20 μs |  31.99 μs | 3,536.1 μs |         - |    24034 B |
| &#39;record - Array.containsByExistsInline&#39; |   284.1 μs |   1.49 μs |   1.32 μs |   284.0 μs |         - |       32 B |
