``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.3208)
12th Gen Intel Core i7-12800H, 1 CPU, 20 logical and 14 physical cores
.NET SDK=8.0.100-preview.6.23330.14
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|                                 Method |        Mean |     Error |    StdDev |      Gen0 |  Allocated |
|--------------------------------------- |------------:|----------:|----------:|----------:|-----------:|
|                    &#39;int - List.exists&#39; |    772.1 μs |   7.96 μs |   7.05 μs |    2.9297 |    48041 B |
|                  &#39;int - List.contains&#39; | 10,129.4 μs | 194.72 μs | 447.41 μs | 1906.2500 | 24024049 B |
|          &#39;int - List.containsByExists&#39; |  9,176.5 μs | 183.31 μs | 268.69 μs | 1906.2500 | 24048049 B |
|    &#39;int - List.containsByExistsInline&#39; |    695.5 μs |  13.81 μs |  23.45 μs |    0.9766 |    24041 B |
|           &#39;int - List.containsMutable&#39; |    858.6 μs |  16.52 μs |  23.16 μs |         - |       41 B |
|           &#39;int - List.containsTryFind&#39; |    566.5 μs |  11.30 μs |  12.56 μs |    2.9297 |    48041 B |
|                 &#39;string - List.exists&#39; |  1,371.8 μs |  27.23 μs |  27.97 μs |    1.9531 |    48041 B |
|               &#39;string - List.contains&#39; |  2,289.6 μs |  17.46 μs |  13.63 μs |         - |       42 B |
|       &#39;string - List.containsByExists&#39; |  2,959.2 μs |  56.33 μs |  73.24 μs |         - |    24042 B |
| &#39;string - List.containsByExistsInline&#39; |  1,229.0 μs |  19.83 μs |  24.36 μs |         - |    24041 B |
|        &#39;string - List.containsMutable&#39; |  1,601.4 μs |   8.54 μs |   7.57 μs |         - |       41 B |
|        &#39;string - List.containsTryFind&#39; |  1,027.4 μs |   4.14 μs |   3.23 μs |    1.9531 |    48041 B |
|                 &#39;record - List.exists&#39; |    767.8 μs |  17.52 μs |  50.00 μs |    2.9297 |    48041 B |
|               &#39;record - List.contains&#39; |  4,011.1 μs |  78.94 μs | 125.21 μs |         - |       42 B |
|       &#39;record - List.containsByExists&#39; |  4,293.4 μs |  84.44 μs | 199.04 μs |         - |    48045 B |
| &#39;record - List.containsByExistsInline&#39; |  1,026.9 μs |  20.53 μs |  45.49 μs |         - |    24041 B |
|        &#39;record - List.containsMutable&#39; |  1,157.2 μs |  10.93 μs |   9.13 μs |         - |       41 B |
|        &#39;record - List.containsTryFind&#39; |    973.5 μs |   7.93 μs |   6.19 μs |    1.9531 |    48041 B |
