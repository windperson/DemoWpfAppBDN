using BenchmarkDotNet.Attributes;
using DemoWpfAppBDN.Pages;

namespace WpfFlowDocBenchmark
{
    [MemoryDiagnoser(displayGenColumns: true)]
    public class RichTextFlowDocBenchmarks
    {
        [Benchmark(Description = "Open RichTextFlowDoc"), STAThread]
#pragma warning disable CA1822
        public void Run()
#pragma warning restore CA1822
        {
            var richTextFlowDoc = new RichTextFlowDoc();
            richTextFlowDoc.Show();
        }
    }
}
