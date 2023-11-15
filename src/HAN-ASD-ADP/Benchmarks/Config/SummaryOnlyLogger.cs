using BenchmarkDotNet.Loggers;
using System;

namespace HAN_ASD_ADP.Benchmarks.Config;

public class SummaryOnlyLogger : ILogger
{
    public string Id => nameof(SummaryOnlyLogger);
    public int Priority => 0;

    public void Write(LogKind logKind, string text) => Console.Write(text);

    public void WriteLine() => Console.WriteLine();

    public void WriteLine(LogKind logKind, string text) => Console.WriteLine(text);

    public void Flush() { }
}
