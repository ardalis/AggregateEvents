using System;

namespace AggregateEvents.Model
{
    public class Task : Entity
    {
        internal Task(string name, int hoursRemaining)
        {
            Name = name;
            HoursRemaining = hoursRemaining;
        }
        private Task()
        {
        }
        public string Name { get; private set; }
        public bool IsComplete { get; private set; }
        public int HoursRemaining { get; private set; }

        public void MarkComplete()
        {
            if (IsComplete) return;
            IsComplete = true;
            HoursRemaining = 0;
            AggregateEvents.Raise(new TaskCompletedEvent(this));
        }

        public void UpdateHoursRemaining(int hours)
        {
            if (hours < 0) return;
            int currentHoursRemaining = HoursRemaining;
            try
            {
                HoursRemaining = hours;
                AggregateEvents.Raise(new TaskHoursUpdatedEvent(this));
                if (HoursRemaining == 0)
                {
                    MarkComplete();
                    return;
                }
                IsComplete = false;
            }
            catch (Exception)
            {
                HoursRemaining = currentHoursRemaining;
            }
        }
    }
}