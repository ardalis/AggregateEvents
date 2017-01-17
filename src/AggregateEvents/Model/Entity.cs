using System;

namespace AggregateEvents.Model
{
    public abstract class Entity
    {
        public Guid Id => Guid.NewGuid();
    }
}