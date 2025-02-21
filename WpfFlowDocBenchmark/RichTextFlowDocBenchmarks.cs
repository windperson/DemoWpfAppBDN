using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DemoWpfAppBDN.Pages;

namespace WpfFlowDocBenchmark
{
    public class RichTextFlowDocBenchmarks
    {
        [Benchmark(Description = "Open RichTextFlowDoc"), System.STAThread]
#pragma warning disable CA1822
        public void Run()
#pragma warning restore CA1822
        {
            var richTextFlowDoc = new RichTextFlowDoc();
            richTextFlowDoc.Show();
        }
    }
}
