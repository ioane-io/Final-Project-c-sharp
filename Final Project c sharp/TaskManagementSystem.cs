using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_c_sharp
{
    public class TaskManagementSystem : ITaskManagementSystem
    {
        private List<TaskList> taskLists;

        public TaskManagementSystem()
        {
            taskLists = new List<TaskList>();
        }

        public void CreateTaskList(string title)
        {
            var newList = new TaskList { Id = taskLists.Count + 1, Title = title, TaskItems = new List<TaskItem>() };
            taskLists.Add(newList);
            Console.WriteLine($"Task List '{title}' created successfully.");
        }

        public void AddTask(int id, string title, string description, DateTime dueDate, Priority priority)
        {
            var taskList = taskLists.Find(tl => tl.Id == id);
            if (taskList != null)
            {
                var newTask = new TaskItem
                {
                    Id = taskList.TaskItems.Count + 1,
                    Title = title,
                    Description = description,
                    DueDate = dueDate,
                    Priority = priority
                };
                taskList.TaskItems.Add(newTask);
                Console.WriteLine($"Task '{title}' added to the list '{taskList.Title}' successfully.");
            }
            else
            {
                Console.WriteLine($"Task List with id '{id}' not found.");
            }
        }

        public void ViewAllTaskLists()
        {
            foreach (var taskList in taskLists)
            {
                Console.WriteLine($"Task List: {taskList.Title}");
                foreach (var task in taskList.TaskItems)
                {
                    Console.WriteLine($"- {task.Title} (Due: {task.DueDate}, Priority: {task.Priority}, Completed: {task.IsCompleted})");
                }
                Console.WriteLine();
            }
        }

        public void MarkTaskAsCompleted(int taskId)
        {
            foreach (var taskList in taskLists)
            {
                var task = taskList.TaskItems.Find(t => t.Id == taskId);
                if (task != null)
                {
                    task.IsCompleted = true;
                    Console.WriteLine($"Task '{task.Title}' marked as completed.");
                    return;
                }
            }
            Console.WriteLine($"Task with id '{taskId}' not found.");
        }

        public List<TaskItem> GetCompletedTasks()
        {
            var completedTasks = new List<TaskItem>();
            foreach (var taskList in taskLists)
            {
                foreach (var task in taskList.TaskItems)
                {
                    if (task.IsCompleted)
                    {
                        completedTasks.Add(task);
                    }
                }
            }
            return completedTasks;
        }
    }
}