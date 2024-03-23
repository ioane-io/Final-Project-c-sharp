using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_c_sharp
{
    public class TaskList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<TaskItem> TaskItems { get; set; }
    }
}