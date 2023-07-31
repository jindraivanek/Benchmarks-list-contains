``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.3208)
12th Gen Intel Core i7-12800H, 1 CPU, 20 logical and 14 physical cores
.NET SDK=8.0.100-preview.6.23330.14
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|                                Method |      Mean |     Error |    StdDev |      Gen0 |   Allocated |
|-------------------------------------- |----------:|----------:|----------:|----------:|------------:|
|                    &#39;int - Seq.exists&#39; |  1.726 ms | 0.0030 ms | 0.0025 ms |    7.8125 |   101.62 KB |
|                  &#39;int - Seq.contains&#39; |  1.223 ms | 0.0062 ms | 0.0058 ms |    3.9063 |    54.74 KB |
|          &#39;int - Seq.containsByExists&#39; |  9.797 ms | 0.0944 ms | 0.0883 ms | 1906.2500 | 23539.13 KB |
|    &#39;int - Seq.containsByExistsInline&#39; |  1.659 ms | 0.0279 ms | 0.0322 ms |    5.8594 |    78.18 KB |
|                 &#39;string - Seq.exists&#39; |  8.947 ms | 0.1085 ms | 0.0962 ms | 1265.6250 | 15540.02 KB |
|               &#39;string - Seq.contains&#39; |  9.021 ms | 0.1768 ms | 0.2105 ms | 1250.0000 | 15493.14 KB |
|       &#39;string - Seq.containsByExists&#39; | 10.791 ms | 0.2136 ms | 0.2285 ms | 1265.6250 | 15516.58 KB |
| &#39;string - Seq.containsByExistsInline&#39; |  8.381 ms | 0.0689 ms | 0.0610 ms | 1265.6250 | 15516.58 KB |
|                 &#39;record - Seq.exists&#39; | 10.212 ms | 0.0790 ms | 0.0739 ms | 2546.8750 | 31211.89 KB |
|               &#39;record - Seq.contains&#39; |  9.803 ms | 0.1159 ms | 0.1027 ms | 2531.2500 | 31165.02 KB |
|       &#39;record - Seq.containsByExists&#39; | 12.846 ms | 0.1823 ms | 0.1522 ms | 2546.8750 | 31211.89 KB |
| &#39;record - Seq.containsByExistsInline&#39; | 10.444 ms | 0.1289 ms | 0.1143 ms | 2531.2500 | 31188.45 KB |
