``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.3208)
12th Gen Intel Core i7-12800H, 1 CPU, 20 logical and 14 physical cores
.NET SDK=8.0.100-preview.6.23330.14
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|                                 Method |       Mean |     Error |    StdDev |     Median |      Gen0 |  Allocated |
|--------------------------------------- |-----------:|----------:|----------:|-----------:|----------:|-----------:|
|                    &#39;int - List.exists&#39; |   785.5 μs |   9.62 μs |   9.00 μs |   784.0 μs |    2.9297 |    48041 B |
|                  &#39;int - List.contains&#39; | 9,284.4 μs | 158.63 μs | 148.38 μs | 9,266.7 μs | 1906.2500 | 24024049 B |
|          &#39;int - List.containsByExists&#39; | 9,068.0 μs | 108.59 μs |  90.67 μs | 9,034.4 μs | 1906.2500 | 24048049 B |
|    &#39;int - List.containsByExistsInline&#39; |   695.4 μs |  13.82 μs |  24.92 μs |   691.4 μs |    0.9766 |    24041 B |
|           &#39;int - List.containsMutable&#39; |   840.1 μs |  10.33 μs |   9.16 μs |   843.2 μs |         - |       41 B |
|           &#39;int - List.containsTryFind&#39; |   566.2 μs |  11.21 μs |  21.06 μs |   558.9 μs |    2.9297 |    48041 B |
|       &#39;int - List.outerContainsWhatIf&#39; |   548.4 μs |  10.35 μs |  15.17 μs |   541.9 μs |         - |       41 B |
|                 &#39;string - List.exists&#39; | 1,376.0 μs |  26.54 μs |  34.51 μs | 1,373.1 μs |    1.9531 |    48041 B |
|               &#39;string - List.contains&#39; | 2,393.9 μs |  43.59 μs |  83.98 μs | 2,359.5 μs |         - |       42 B |
|       &#39;string - List.containsByExists&#39; | 3,699.8 μs | 197.62 μs | 579.57 μs | 3,653.1 μs |         - |    24042 B |
| &#39;string - List.containsByExistsInline&#39; | 1,332.1 μs |  26.59 μs |  75.86 μs | 1,314.9 μs |         - |    24041 B |
|        &#39;string - List.containsMutable&#39; | 1,637.5 μs |  32.71 μs |  63.03 μs | 1,610.3 μs |         - |       41 B |
|        &#39;string - List.containsTryFind&#39; | 1,113.8 μs |  22.80 μs |  66.88 μs | 1,101.8 μs |    1.9531 |    48041 B |
|    &#39;string - List.outerContainsWhatIf&#39; |   838.6 μs |  21.62 μs |  62.38 μs |   824.1 μs |         - |       41 B |
|                 &#39;record - List.exists&#39; |   789.1 μs |  21.43 μs |  62.85 μs |   770.7 μs |    2.9297 |    48041 B |
|               &#39;record - List.contains&#39; | 3,796.8 μs |  66.80 μs | 113.44 μs | 3,753.0 μs |         - |       45 B |
|       &#39;record - List.containsByExists&#39; | 3,927.7 μs |  34.48 μs |  30.57 μs | 3,924.5 μs |         - |    48045 B |
| &#39;record - List.containsByExistsInline&#39; |   987.5 μs |  19.62 μs |  55.00 μs |   969.5 μs |         - |    24041 B |
|        &#39;record - List.containsMutable&#39; | 1,147.1 μs |  18.58 μs |  15.52 μs | 1,151.4 μs |         - |       41 B |
|        &#39;record - List.containsTryFind&#39; | 1,002.2 μs |  19.40 μs |  22.34 μs |   994.7 μs |    1.9531 |    48041 B |
|    &#39;record - List.outerContainsWhatIf&#39; |   691.4 μs |  13.61 μs |  16.20 μs |   688.9 μs |         - |       41 B |
