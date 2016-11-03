using System;
using System.Collections.Generic;
using System.Linq;

namespace AggregateEvents
{
    public static class DomainEvents
    {
        [ThreadStatic] //so that each thread has its own callbacks
        private static List<Delegate> _actions;

        public static void Register<T>(Action<T> callback) where T : AggregateEvent
        {
            if (_actions == null)
            {
                _actions = new List<Delegate>();
            }

            _actions.Add(callback);
        }

        public static void ClearCallbacks()
        {
            _actions = null;
        }

        public static void Raise<T>(T args) where T : AggregateEvent
        {
            if (_actions == null) return;
            foreach (var action in _actions.OfType<Action<T>>())
            {
                action(args);
            }
        }
    }
}