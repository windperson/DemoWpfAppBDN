using BenchmarkDotNet.Attributes;
using DemoWpfAppBDN.Pages;

namespace WpfFlowDocBenchmark
{
    public class RichTextFlowDocBenchmarks
    {
        [Benchmark, System.STAThread]
#pragma warning disable CA1822
        public void Run()
#pragma warning restore CA1822
        {
            var sut = new RichTextFlowDoc();
            sut.Show();
        }
    }
}
