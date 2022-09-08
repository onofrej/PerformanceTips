using BenchmarkDotNet.Attributes;

namespace PerformanceTips.Benchmarks
{
    [MemoryDiagnoser, RankColumn]
    public class TryCatchComparison
    {
        [Benchmark]
        [Arguments(100, 100)]
        public int WithTryCatch(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                throw;
            }
        }

        [Benchmark]
        [Arguments(100, 100)]
        public int WithoutTryCatch(int a, int b)
        {
            return a + b;
        }
    }
}