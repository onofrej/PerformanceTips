using BenchmarkDotNet.Running;
using PerformanceTips.Benchmarks;

BenchmarkRunner.Run(typeof(CollectionReturnComparison));
//BenchmarkRunner.Run(typeof(ListSizeComparison));
//BenchmarkRunner.Run(typeof(StringCaseComparison));
//BenchmarkRunner.Run(typeof(TaskReturnComparison));
//BenchmarkRunner.Run(typeof(TryCatchComparison));