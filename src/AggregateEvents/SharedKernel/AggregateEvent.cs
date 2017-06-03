using System;

namespace AggregateEvents
{
    public abstract class AggregateEvent
    {
        public DateTimeOffset DateOccurred { get; private set; } = DateTime.UtcNow;
    }
}