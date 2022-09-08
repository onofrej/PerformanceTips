using BenchmarkDotNet.Attributes;
using System.Globalization;

namespace PerformanceTips.Benchmarks
{
    [MemoryDiagnoser, RankColumn]
    public class StringCaseComparison
    {
        private const string Environment = "development";

        [Benchmark]
        [Arguments("Development")]
        public bool CompareWithoutParameter(string environment)

        {
            return environment.ToLower() == Environment;
        }

        [Benchmark]
        [Arguments("Development")]
        public bool CompareWithInvariantCulture(string environment)
        {
            return environment.ToLower(CultureInfo.InvariantCulture) == Environment;
        }

        [Benchmark]
        [Arguments("Development")]
        public bool CompareWithInvariantCultureIgnoreCase(string environment)
        {
            return string.Equals(environment, Environment, StringComparison.InvariantCultureIgnoreCase);
        }

        [Benchmark]
        [Arguments("Development")]
        public bool CompareVariableWithInvariantCultureIgnoreCase(string environment)
        {
            return environment.Equals(Environment, StringComparison.InvariantCultureIgnoreCase);
        }

        [Benchmark]
        [Arguments("Development")]
        public bool CompareWithOrdinalIgnoreCase(string environment)
        {
            return string.Equals(environment, Environment, StringComparison.OrdinalIgnoreCase);
        }

        [Benchmark]
        [Arguments("Development")]
        public bool CompareVariableWithOrdinalIgnoreCase(string environment)
        {
            return environment.Equals(Environment, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}