using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.Extensions.Logging;

namespace logging_performance
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BenchmarkLogging
    {
        private static readonly ILogger Logger;
        private static readonly Random Random;

        private int Data => Random.Next();

        static BenchmarkLogging()
        {
            Logger = new LoggerFactory().CreateLogger("Logger");
            Random = new Random();
        }

        [Benchmark]
        public void Templated()
        {
            Logger.LogInformation("data: {Data}", Data);
        }

        [Benchmark]
        public void Interpolated()
        {
            Logger.LogInformation($"data: {Data}");
        }

        [Benchmark]
        public void Formatted()
        {
            Logger.LogInformation(String.Format("data: {0}", Data));
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkLogging>();
        }
    }
}