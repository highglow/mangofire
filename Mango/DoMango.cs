using System;
using System.Linq;
using System.Threading;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.CSharp.RuntimeBinder;

namespace Mango
{
    public static class DoMango
    {
        [FunctionName("DoMango")]
        public static void Run([TimerTrigger("*/30 * * * * *", RunOnStartup = true)]TimerInfo myTimer, TraceWriter log)
        {
            log.Info($"C# Timer trigger function executed at: {DateTime.Now}");
            var stuff = Enumerable.Range(1, 20);

            foreach(var x in stuff)
            {
                var msg = $"x @ {DateTime.Now}";
                Console.WriteLine($"console {msg}");
                log.Warning($"TraceWritter {msg}");
                Thread.Sleep(100);
            };
        }
    }
}
