using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace WpfFlowDocBenchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = DefaultConfig.Instance.AddJob(
                Job.MediumRun.WithWarmupCount(2)
                    .WithIterationCount(5)
                    .WithPowerPlan(PowerPlan.UserPowerPlan)
                    .AsDefault());
            var summary = BenchmarkRunner.Run<RichTextFlowDocBenchmarks>(config, args);
        }
    }
}
