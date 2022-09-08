``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19043.1889/21H1/May2021Update)
Intel Core i7-6700HQ CPU 2.60GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT AVX2


```
|           Method |        Mean |     Error |    StdDev | Rank |   Gen0 | Allocated |
|----------------- |------------:|----------:|----------:|-----:|-------:|----------:|
|  WithYieldReturn |    20.34 ns |  0.109 ns |  0.091 ns |    1 | 0.0357 |     112 B |
| WithSelectReturn |    31.37 ns |  0.121 ns |  0.101 ns |    2 | 0.0357 |     112 B |
|    WithAddValues | 3,045.46 ns | 12.020 ns | 10.037 ns |    3 | 1.7662 |    5544 B |
