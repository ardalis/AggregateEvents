namespace AggregateEvents.Model
{
    public class TaskDeletedEvent : AggregateEvent
    {
        public Task Task { get; set; }

        public TaskDeletedEvent(Task task)
        {
            Task = task;
        }
    }
}