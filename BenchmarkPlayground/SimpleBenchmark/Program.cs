using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace SimpleBenchmark
{
    [MemoryDiagnoser]
    public class EnumTests
    {
        private const OperationStatus Status = OperationStatus.Success;

        [Benchmark]
        public void EnumToString()
            => Status.ToString();
		
        [Benchmark]
        public void EnumToStringCode()
            => Status.ToStringCode();
        
        [Benchmark]
        public void EnumToStringCodeUpperCaseUsingToUpper()
            => Status.ToStringCode().ToUpper();
		
        [Benchmark]
        public void EnumToStringCodeUpperCaseUsingExtension()
            => Status.ToStringCodeUpperCase();
    }

    internal class Program
    {
        public static void Main(string[] args)
            => BenchmarkRunner.Run<EnumTests>();
    }
}