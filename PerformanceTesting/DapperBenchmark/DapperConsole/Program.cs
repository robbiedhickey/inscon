using System;
using DapperRunner;
using DapperRunner.Model;

namespace DapperConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformanceTimer.Wrap("Dapper", () => new LLBLTestSuite().ExecuteWriteTest<People>(Constants.ConnectionString, Constants.FilePath));

            PerformanceTimer.GetSummary();

            Console.ReadLine();

        }
    }
}
