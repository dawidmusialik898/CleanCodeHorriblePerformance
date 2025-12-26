using BenchmarkDotNet.Running;
using CleanCode;

var summary = BenchmarkRunner.Run<ExecutorBenchmark>();
