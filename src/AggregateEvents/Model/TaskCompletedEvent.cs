namespace AggregateEvents.Model
{
    public class TaskCompletedEvent : AggregateEvent
    {
        public Task Task { get; set; }

        public TaskCompletedEvent(Task task)
        {
            Task = task;
        }
    }
    public class TaskHoursUpdatedEvent : AggregateEvent
    {
        public Task Task { get; set; }

        public TaskHoursUpdatedEvent(Task task)
        {
            Task = task;
        }
    }
}