using System;

namespace BPMS.Shared.Layout
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public TaskFlagEnum Flag { get; set; }
        public TaskPriorityEnum Proirity { get; set; }
        public DateTime Created { get; set; }
        public DateTime Done { get; set; }
        public string Sender { get; set; }
        public bool IsNew { get; set; }
    }

    public enum TaskFlagEnum
    { None, Red, Green, Blue, Black }

    public enum TaskPriorityEnum
    { None, Low, Medium, High, Urgent }
}