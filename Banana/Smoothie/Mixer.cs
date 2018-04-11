using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs.Host;

namespace Banana.Smoothie
{
    public class Mixer
    {
        private TraceWriter _log;

        public Mixer(TraceWriter log)
        {
            _log = log;
        }

        public void Blend()
        {
            _log.Info("Hello Im blending stuff");

            var stuff = Enumerable.Range(1, 20);

            foreach (var x in stuff)
            {
                var msg = $"{x} @ {DateTime.Now}";
                Console.WriteLine($"console {msg}");
                _log.Warning($"TraceWritter {msg}");
                Thread.Sleep(100);
            };

        }
    }
}
