## Purpose of repositry
Repository created to check how that YT video:
https://www.youtube.com/watch?v=tD5NrevFtbU
applies to modern c#.

## How to run
Uisng dotnet cli: 'dotnet run -c Release'

## Benchmark spec
BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Intel Core i5-7200U CPU 2.50GHz (Max: 2.71GHz) (Kaby Lake), 1 CPU, 2 logical cores and 1 physical core
.NET SDK 8.0.404
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3

## Benchmark results
### GetArea

| Method                                | Mean      | Error    | StdDev   |
|-------------------------------------- |----------:|---------:|---------:|
| CleanCode                             | 183.14 ns | 3.305 ns | 4.180 ns |
| CleanCodeWithoutPoly                  | 297.47 ns | 5.846 ns | 6.003 ns |
| CleanCodeWithoutPolyAndKnowingInsides |  76.96 ns | 1.188 ns | 1.111 ns |

Converting it to mentioned video mesure that is cycle/shape:
1. My processor have 2.5-2.71 cycles/ns. I'll be using max value in calculations.
2. Benchmark was run for 64 shapes.
3. Resulting table:

| Method                                | Mean in cycles| Notes
|-------------------------------------- |---------------|------------------------
| CleanCode                             |  7.72 cycle   | 183/64*2.7
| CleanCodeWithoutPoly                  | 12.52 cycle   | 297/64*2.7
| CleanCodeWithoutPolyAndKnowingInsides |  3.21 cycle   | 76/64*2.7
