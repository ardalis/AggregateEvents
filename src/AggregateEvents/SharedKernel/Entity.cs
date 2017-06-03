using System;

namespace AggregateEvents.Model
{
    public abstract class Entity
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}