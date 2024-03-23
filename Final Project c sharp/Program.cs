namespace Final_Project_c_sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var taskManagementSystem = new TaskManagementSystem();
            while (true)
            {
                Console.WriteLine("1. Create Task List");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. View All Task Lists");
                Console.WriteLine("4. Mark Task as Completed");
                Console.WriteLine("5. Get Completed Tasks");
                Console.WriteLine("Enter your choice (1-5):");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter Task List Title:");
                        var title = Console.ReadLine();
                        taskManagementSystem.CreateTaskList(title);
                        break;
                    case "2":
                        Console.WriteLine("Enter Task List Id:");
                        var taskId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Task Title:");
                        var taskTitle = Console.ReadLine();
                        Console.WriteLine("Enter Task Description:");
                        var taskDescription = Console.ReadLine();
                        Console.WriteLine("Enter Task Due Date (yyyy-MM-dd):");
                        var dueDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Task Priority (Low/Medium/High):");
                        var priority = Enum.Parse<Priority>(Console.ReadLine(), true);
                        taskManagementSystem.AddTask(taskId, taskTitle, taskDescription, dueDate, priority);
                        break;
                    case "3":
                        taskManagementSystem.ViewAllTaskLists();
                        break;
                    case "4":
                        Console.WriteLine("Enter Task Id to mark as completed:");
                        var taskIdToComplete = int.Parse(Console.ReadLine());
                        taskManagementSystem.MarkTaskAsCompleted(taskIdToComplete);
                        break;
                    case "5":
                        var completedTasks = taskManagementSystem.GetCompletedTasks();
                        Console.WriteLine("Completed Tasks:");
                        foreach (var task in completedTasks)
                        {
                            Console.WriteLine($"- {task.Title}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
        }
    }
}