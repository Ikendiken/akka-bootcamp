using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartApp.Actors
{
    public class PerformanceCounterCoordinatorActor : ReceiveActor
    {
        public class Watch
        {
            public Watch(CounterType counter)
            {
                Counter = counter;
            }

            public CounterType Counter { get; private set; }
        }

        public class Unwatch
        {
            public Unwatch(CounterType counter)
            {
                Counter = counter;
            }
            public CounterType Counter { get; private set; }
        }
    }
}
