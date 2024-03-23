using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_c_sharp
{
    public interface ITaskManagementSystem
    {
        void CreateTaskList(string title);
        void AddTask(int id, string title, string description, DateTime dueDate, Priority priority);
        void ViewAllTaskLists();
        void MarkTaskAsCompleted(int taskId);
        List<TaskItem> GetCompletedTasks();
    }
}