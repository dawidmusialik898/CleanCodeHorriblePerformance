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
| GetAreaVirtualFunctions               | 183.14 ns | 3.305 ns | 4.180 ns |
| GetAreaSwitch                         | 297.47 ns | 5.846 ns | 6.003 ns |
| GetAreaSwitchInline                   | 134.28 ns | 2.283 ns | 1.907 ns |
| GetAreaIf                             | 103.91 ns | 1.200 ns | 1.123 ns |
| GetAreaTable                          |  76.96 ns | 1.188 ns | 1.111 ns |

Converting it to mentioned video mesure that is cycle/shape:
1. My processor have 2.5-2.71 cycles/ns. I'll be using max value in calculations.
2. Benchmark was run for 64 shapes.
3. Results presented in (cy)cles per (sh)ape.
4. Resulting table:

| Method                                | Mean          | Notes
|-------------------------------------- |---------------|------------------------
| GetAreaVirtualFunction                |  7.72 cy/sh   | 183/64*2.7
| GetAreaSwitch                         | 12.52 cy/sh   | 297/64*2.7
| GetAreaSwitchInline                   |  5.65 cy/sh   | 134/64*2.7
| GetAreaIf                             |  4.35 cy/sh   | 103/64*2.7
| GetAreaTable                          |  3.21 cy/sh   | 76/64*2.7

### More results
More results available in BenchmarkDotNet.Artifacts/results
## Open question why does swtich perfrom so badly?
After disassembling each methods it is visible that for some reason JIT is not inlining switch method but ifs are inlinded.
Inlined switch performs much better, and closer to the 'if' implementation.
