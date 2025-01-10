# BenchmarkDotNet WPF Demo

This is a demo project to demonstrates how to use [BenchmarkDotNet](https://benchmarkdotnet.org/) to run benchmarks for a custom Window UI part of a .NET 8.0 WPF application.

## How to run the benchmarks

### Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

### Run the benchmark

On Windows, in the **WpfFlowDocBenchmark** folder run the following command:

```sh
dotnet run -c Release -- *
```

![screen shot](./pics/run_benchmark.png)
