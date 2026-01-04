## Purpose of repositry
Repository created to check how that YT video:
https://www.youtube.com/watch?v=tD5NrevFtbU
applies to modern c#.

## How to run
Uisng dotnet cli: 'dotnet run -c Release'

## Benchmark spec
BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Intel Core i5-7200U CPU 2.50GHz (Max: 2.71GHz) (Kaby Lake), 1 CPU, 2 logical cores and 1 physical core
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3

## Benchmark results
### GetArea

| Method                  | Mean      | Error    | StdDev    | Code Size |
|------------------------ |----------:|---------:|----------:|----------:|
| GetAreaVirtualFunctions | 178.37 ns | 3.594 ns |  3.362 ns |     129 B |
| GetAreaSwitch           | 249.70 ns | 5.026 ns | 10.712 ns |     222 B |
| GetAreaSwitchInline     | 102.09 ns | 2.091 ns |  4.271 ns |     161 B |
| GetAreaIf               | 111.09 ns | 1.356 ns |  1.202 ns |     120 B |
| GetAreaTable            |  80.03 ns | 2.214 ns |  6.354 ns |      89 B |

Converting it to mentioned video mesure that is cycle/shape:
1. My processor have 2.5-2.71 cycles/ns. I'll be using max value in calculations.
2. Benchmark was run for 64 shapes.
3. Results presented in (cy)cles per (sh)ape.
4. Resulting table:

| Method                                | Mean          | Notes
|-------------------------------------- |---------------|------------------------
| GetAreaVirtualFunction                |  7.51 cy/sh   | 178/64*2.7
| GetAreaSwitch                         | 10.55 cy/sh   | 250/64*2.7
| GetAreaSwitchInline                   |  4.03 cy/sh   | 102/64*2.7
| GetAreaIf                             |  4.68 cy/sh   | 111/64*2.7
| GetAreaTable                          |  3.38 cy/sh   | 80/64*2.7

### More results
More results available in BenchmarkDotNet.Artifacts/results
## Why original switch performed so badly?
After disassembling each methods it is visible that for some reason JIT is not inlining switch method but ifs are inlinded.
Inlined switch performs much better, and closer to the 'if' implementation.
