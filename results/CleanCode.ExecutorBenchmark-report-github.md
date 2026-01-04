```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Intel Core i5-7200U CPU 2.50GHz (Max: 2.71GHz) (Kaby Lake), 1 CPU, 2 logical cores and 1 physical core
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method                  | Mean      | Error    | StdDev   | Code Size |
|------------------------ |----------:|---------:|---------:|----------:|
| GetAreaVirtualFunctions | 181.70 ns | 3.616 ns | 3.713 ns |     129 B |
| GetAreaSwitch           | 234.89 ns | 4.579 ns | 4.703 ns |     222 B |
| GetAreaSwitchInline     | 123.79 ns | 2.393 ns | 2.121 ns |     161 B |
| GetAreaIf               |  91.69 ns | 1.152 ns | 0.962 ns |     131 B |
| GetAreaTable            |  73.74 ns | 1.513 ns | 1.554 ns |      89 B |
