```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Intel Core i5-7200U CPU 2.50GHz (Max: 2.71GHz) (Kaby Lake), 1 CPU, 2 logical cores and 1 physical core
.NET SDK 8.0.404
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method                  | Mean      | Error    | StdDev   | Code Size |
|------------------------ |----------:|---------:|---------:|----------:|
| GetAreaVirtualFunctions | 186.39 ns | 3.621 ns | 4.024 ns |     154 B |
| GetAreaSwitch           | 317.35 ns | 6.190 ns | 7.128 ns |     255 B |
| GetAreaSwitchInline     | 134.28 ns | 2.283 ns | 1.907 ns |     169 B |
| GetAreaIf               | 108.62 ns | 2.211 ns | 2.271 ns |     128 B |
| GetAreaTable            |  79.63 ns | 1.626 ns | 1.521 ns |     105 B |
