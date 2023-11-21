using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAN_ASD_ADP.Benchmarks.BinarySearch
{
    internal class BinarySearchGetBenchmarks : SetupBinarySearchBenchmarks
    {
        [Benchmark]
        public void Get_First_IndexOfLinearSearch() => array.IndexOfLinearSearch(0);

        [Benchmark]
        public void Get_Mid_IndexOfLinearSearch() => array.IndexOfLinearSearch(Length / 2);

        [Benchmark]
        public void Get_Last_IndexOfLinearSearch() => array.IndexOfLinearSearch(Length - 1);
    }
}
