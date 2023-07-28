``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.3208)
12th Gen Intel Core i7-12800H, 1 CPU, 20 logical and 14 physical cores
.NET SDK=8.0.100-preview.6.23330.14
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|                                 Method |      Mean |     Error |    StdDev |      Gen0 |  Allocated |
|--------------------------------------- |----------:|----------:|----------:|----------:|-----------:|
|                    &#39;int - List.exists&#39; |  1.844 ms | 0.0235 ms | 0.0220 ms |    1.9531 |    48041 B |
|                  &#39;int - List.contains&#39; | 25.150 ms | 0.4391 ms | 0.4108 ms | 1906.2500 | 24024059 B |
|          &#39;int - List.containsByExists&#39; | 27.099 ms | 0.3463 ms | 0.3239 ms | 1906.2500 | 24048059 B |
|    &#39;int - List.containsByExistsInline&#39; |  1.553 ms | 0.0171 ms | 0.0160 ms |         - |    24041 B |
|                 &#39;int - List.contains2&#39; |  2.494 ms | 0.0471 ms | 0.0595 ms |         - |       42 B |
|           &#39;int - List.containsTryFind&#39; |  1.247 ms | 0.0245 ms | 0.0240 ms |    1.9531 |    48041 B |
|                 &#39;string - List.exists&#39; |  3.396 ms | 0.0351 ms | 0.0311 ms |         - |    48042 B |
|               &#39;string - List.contains&#39; |  6.803 ms | 0.1287 ms | 0.1204 ms |         - |       45 B |
|       &#39;string - List.containsByExists&#39; |  8.119 ms | 0.1230 ms | 0.1151 ms |         - |    24049 B |
| &#39;string - List.containsByExistsInline&#39; |  3.393 ms | 0.0451 ms | 0.0422 ms |         - |    24042 B |
|              &#39;string - List.contains2&#39; |  4.448 ms | 0.0770 ms | 0.0721 ms |         - |       45 B |
|        &#39;string - List.containsTryFind&#39; |  3.046 ms | 0.0602 ms | 0.0670 ms |         - |    48042 B |
|                 &#39;record - List.exists&#39; |  1.928 ms | 0.0372 ms | 0.0382 ms |         - |    48042 B |
|               &#39;record - List.contains&#39; | 10.270 ms | 0.1622 ms | 0.1593 ms |         - |       49 B |
|       &#39;record - List.containsByExists&#39; | 11.283 ms | 0.1212 ms | 0.1133 ms |         - |    48049 B |
| &#39;record - List.containsByExistsInline&#39; |  2.344 ms | 0.0235 ms | 0.0208 ms |         - |    24042 B |
|              &#39;record - List.contains2&#39; |  2.888 ms | 0.0455 ms | 0.0487 ms |         - |       42 B |
|        &#39;record - List.containsTryFind&#39; |  1.837 ms | 0.0360 ms | 0.0337 ms |    1.9531 |    48041 B |
