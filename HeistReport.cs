using System;

namespace heist
{
    public class Report
    {
        public Report()
        {
            SuccessCount = 0;
            FailureCount = 0;
        }
        public int SuccessCount { get; set; }
        public int FailureCount { get; set; }

        public void ShowReport()
        {
            Console.WriteLine();
            Console.WriteLine(" <Heist Report> ");
            Console.WriteLine("------------------------");
            Console.WriteLine($"Successful Runs: {SuccessCount}");
            Console.WriteLine($"Failed Runs: {FailureCount}");
            Console.WriteLine();
        }

    }
}