using BenchmarkDotNet.Attributes;

namespace PerformanceTips.Benchmarks
{
    [MemoryDiagnoser, RankColumn]
    public class ListSizeComparison
    {
        private const string counters = "012345678901234567890123456789";

        [Benchmark]
        public List<string> ListWithSize()
        {
            var list = new List<string>(30);

            foreach (var counter in counters)
            {
                list.Add(counter.ToString());
            }

            return list;
        }

        [Benchmark]
        public List<string> ListWithoutSize()
        {
            var list = new List<string>();

            foreach (var counter in counters)
            {
                list.Add(counter.ToString());
            }

            return list;
        }
    }
}