``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.856/21H2)
Intel Core i9-10900 CPU 2.80GHz, 1 CPU, 20 logical and 10 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4515.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8 (4.8.4515.0), X86 LegacyJIT


```
|       Method |      Mean |    Error |   StdDev | Rank |   Gen0 | Allocated |
|------------- |----------:|---------:|---------:|-----:|-------:|----------:|
|    Templated |  56.84 ns | 0.616 ns | 0.546 ns |    1 | 0.0053 |      28 B |
|    Formatted | 205.27 ns | 1.135 ns | 1.062 ns |    2 | 0.0174 |      92 B |
| Interpolated | 205.63 ns | 1.542 ns | 1.367 ns |    2 | 0.0174 |      92 B |
