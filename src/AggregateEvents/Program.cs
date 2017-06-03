using System;
using System.Linq;
using AggregateEvents.Model;

namespace AggregateEvents
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Create a project");
            Console.ReadLine();
            var project = new Project() {Name = "My Project"};
            Console.WriteLine(project);
            Console.ReadLine();

            Console.WriteLine("Add a couple of tasks.");
            Console.ReadLine();
            project.AddTask("First Task", 2);
            project.AddTask("Second Task", 3);
            Console.WriteLine(project);
            Console.ReadLine();

            Console.WriteLine("Mark a task completed - should set hours to 0.");
            Console.ReadLine();
            project.Tasks.First().MarkComplete();
            Console.WriteLine(project);
            Console.ReadLine();

            Console.WriteLine("Update the hours on another task to 0.");
            Console.ReadLine();
            project.Tasks.First(t => !t.IsComplete).UpdateHoursRemaining(0);
            Console.WriteLine(project);
            Console.ReadLine();

            Console.ReadLine();
            Console.WriteLine("Update the hours remaining again - status should no longer be done");
            project.Tasks.First().UpdateHoursRemaining(9);
            Console.WriteLine(project);
            Console.ReadLine();

            Console.WriteLine("Update the hours so that total hours exceeds limit - shouldn't work");
            Console.ReadLine();
            project.Tasks.Last().UpdateHoursRemaining(2);
            Console.WriteLine(project);
            Console.ReadLine();
        }
    }
}
