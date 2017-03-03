using AggregateEvents.Model;
using System;
using System.Linq;
using Xunit;

namespace AggregateEvents.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void UpdateTaskName()
        {
            var project = new Project();
            project.AddTask("Task 1", 5);

            // get project from persistence

            var myTask = project.Tasks.First();

            myTask.UpdateHoursRemaining(2);

            // save project

        }
    }
}
