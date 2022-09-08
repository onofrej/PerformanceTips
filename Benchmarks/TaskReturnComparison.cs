using BenchmarkDotNet.Attributes;

namespace PerformanceTips.Benchmarks
{
    [MemoryDiagnoser, RankColumn]
    public class TaskReturnComparison
    {
        [Benchmark]
        public async Task<object> ReturningWithFromResult()
        {
            return await Task.FromResult(new { name = "Onofre" });
        }

        [Benchmark]
        public ValueTask<object> ReturningWithValueTaskElidingAsync()
        {
            return new ValueTask<object>(new { name = "Onofre" });
        }

        [Benchmark]
        public async ValueTask<object> ReturningWithValueTask()
        {
            return await Task.FromResult(new { name = "Onofre" });
        }

        [Benchmark]
        public async Task<object> ReturningWithTaskRun()
        {
            return await Task.Run(() => new { name = "Onofre" });
        }
    }
}