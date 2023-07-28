``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.3208)
12th Gen Intel Core i7-12800H, 1 CPU, 20 logical and 14 physical cores
.NET SDK=7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
|                                Method |      Mean |     Error |    StdDev |      Gen0 |   Allocated |
|-------------------------------------- |----------:|----------:|----------:|----------:|------------:|
|                    &#39;int - Seq.exists&#39; |  3.937 ms | 0.0760 ms | 0.0961 ms |    7.8125 |   101.62 KB |
|                  &#39;int - Seq.contains&#39; |  2.885 ms | 0.0559 ms | 0.0574 ms |    3.9063 |    54.74 KB |
|          &#39;int - Seq.containsByExists&#39; | 29.364 ms | 0.4812 ms | 0.4501 ms | 1906.2500 | 23539.14 KB |
|    &#39;int - Seq.containsByExistsInline&#39; |  3.682 ms | 0.0726 ms | 0.0864 ms |         - |    78.18 KB |
|                 &#39;string - Seq.exists&#39; | 20.745 ms | 0.2531 ms | 0.2114 ms | 1250.0000 | 15540.03 KB |
|               &#39;string - Seq.contains&#39; | 21.457 ms | 0.3560 ms | 0.3330 ms | 1250.0000 | 15493.15 KB |
|       &#39;string - Seq.containsByExists&#39; | 25.581 ms | 0.4793 ms | 0.4484 ms | 1250.0000 | 15516.59 KB |
| &#39;string - Seq.containsByExistsInline&#39; | 21.232 ms | 0.3437 ms | 0.3678 ms | 1250.0000 | 15516.59 KB |
|                 &#39;record - Seq.exists&#39; | 23.734 ms | 0.2825 ms | 0.2643 ms | 2531.2500 |  31211.9 KB |
|               &#39;record - Seq.contains&#39; | 22.695 ms | 0.2858 ms | 0.2534 ms | 2531.2500 | 31165.03 KB |
|       &#39;record - Seq.containsByExists&#39; | 33.592 ms | 0.6649 ms | 0.6530 ms | 2500.0000 | 31211.92 KB |
| &#39;record - Seq.containsByExistsInline&#39; | 23.483 ms | 0.4104 ms | 0.3638 ms | 2531.2500 | 31188.46 KB |
