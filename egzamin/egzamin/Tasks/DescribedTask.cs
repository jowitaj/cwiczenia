using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace egzamin.Tasks
{
    public class DescribedTask: PriorityTask
    {
        //1 linijka w 1
        public string Description { get; set; }
        //1 linijka w 2
        public DescribedTask()
        {
            Name = "Empty";
            Priority = 0;
        }

        // 2 linijka w 2
        public DescribedTask(string name, int priority, string description) : base(name, priority)
        {
            Name = name;
            Priority = priority;
            Description = description;
        }
        // 3 linijka w 2
        public DescribedTask(DescribedTask task) : base(task)
        {
            Name = task.Name;
            Priority = task.Priority;
            Description = task.Description;
        }

        public override string ToString()
        {
            string output = "";
            return output;
        }
    }
}
