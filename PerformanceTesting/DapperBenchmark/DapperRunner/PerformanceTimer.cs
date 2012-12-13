using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DapperRunner
{
    public static class PerformanceTimer
    {
        private static List<KeyValuePair<string,long>> cache = new List<KeyValuePair<string, long>>();

        public static void Wrap(string callerName,Action action)
        {
            var timer = Stopwatch.StartNew();
            timer.Start();
            action();
            timer.Stop();
            cache.Add(new KeyValuePair<string, long>(callerName, timer.ElapsedMilliseconds));
            Console.WriteLine("{0}: {1}", callerName, timer.ElapsedMilliseconds);
        }

        public static string GetSummary()
        {
            var runnerNames = cache.Select(k => k.Key).Distinct();
            var sb = new StringBuilder();
            foreach (var runnerName in runnerNames)
            {
               sb.AppendFormat("{0}: Average Elapsed Time Was {1} MS and Total Elapsed Time was {2} minutes\n", runnerName, 
                                                                                cache.Where(k => k.Key == runnerName).Average(k => k.Value),   
                                                                                TimeSpan.FromMilliseconds(cache.Where(k=> k.Key == runnerName).Sum(k => k.Value)).TotalMinutes);
            }

            return sb.ToString();
        }

        public static void TearDown()
        {
            cache.Clear();
        }

    }
}
