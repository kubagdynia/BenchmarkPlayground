using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace SimpleBenchmark
{
    [MemoryDiagnoser]
    public class EnumTests
    {
        private const OperationStatus Status = OperationStatus.Success;
        private const OperationType Type = OperationType.Update;

        [Benchmark]
        public void EnumToString()
        {
            Type.ToString();
            Status.ToString();
        } 
		
        [Benchmark]
        public void EnumToStringCode()
        {
            Type.ToStringCode();
            Status.ToStringCode();
        }
        
        [Benchmark]
        public void EnumToStringCodeUpperCaseUsingToUpper()
        {
            Type.ToStringCode().ToUpper();
            Status.ToStringCode().ToUpper();
        }
		
        [Benchmark]
        public void EnumToStringCodeUpperCaseUsingExtension()
        {
            Type.ToStringCodeUpperCase();
            Status.ToStringCodeUpperCase();
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<EnumTests>();
        }
    }
}