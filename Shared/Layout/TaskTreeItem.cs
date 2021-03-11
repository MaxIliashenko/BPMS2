using System;
using System.Collections.Generic;

namespace BPMS.Shared.Layout
{
    public class TaskTreeItem
    {
        public Guid Id { get; set; }
        public TaskTreeItemType ItemType { get; set; }
        public string ItemTypeName => ItemType.ToString();
        public string Text { get; set; }
        public int TasksCount { get; set; }
        public int NewTasksCount { get; set; }
        public List<TaskTreeItem> ChildItems { get; set; } = new();

        public TaskTreeItem(Guid id, TaskTreeItemType itemType, string text, int tasksCount = 0, int newTasksCount = 0)
        {
            Id = id;
            ItemType = itemType;
            Text = text;
            TasksCount = tasksCount;
            NewTasksCount = newTasksCount;
        }
    }

    public enum TaskTreeItemType
    {
        User, Role, Folder, TaskFolder
    }
}
