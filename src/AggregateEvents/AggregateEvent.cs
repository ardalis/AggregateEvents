using System;
using AggregateEvents.Model;

namespace AggregateEvents
{
    public abstract class AggregateEvent
    {
        public DateTimeOffset DateOccurred { get; private set; } = DateTime.UtcNow;
    }
}