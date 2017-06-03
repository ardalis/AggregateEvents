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
}