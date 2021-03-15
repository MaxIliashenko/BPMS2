using BPMS.Shared.Interfaces.Services;
using BPMS.Shared.Layout;
using BPMS.Shared.Localization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BPMS.Server.Services
{
    public class TaskService : ITaskService
    {
        public async Task<List<TaskTreeItem>> GetTaskTree()
        {
            var res = new List<TaskTreeItem>();

            var u = new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.User, "Test User");
            res.Add(u);

            var upt = new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.Folder, "Pending Tasks".loc(), 3, 1);
            u.ChildItems.Add(upt);
            upt.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 1"));
            upt.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 2"));
            upt.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 3"));

            var ud = new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.Folder, "Drafts".loc(), 0, 0);
            u.ChildItems.Add(ud);

            var uc = new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.Folder, "Completed Tasks".loc(), 25, 0);
            u.ChildItems.Add(uc);
            uc.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 1"));
            uc.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 2"));
            uc.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 3"));

            var rd = new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.Role, "Developer");
            res.Add(rd);

            var rdupt = new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.Folder, "Pending Tasks".loc(), 10, 2);
            rd.ChildItems.Add(rdupt);
            rdupt.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 1"));
            rdupt.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 2"));
            rdupt.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 3"));

            var rdd = new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.Folder, "Drafts".loc(), 0, 0);
            rd.ChildItems.Add(rdd);

            var rdc = new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.Folder, "Completed Tasks".loc(), 100, 0);
            rd.ChildItems.Add(rdc);
            rdc.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 1"));
            rdc.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 2"));
            rdc.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 3"));

            var rm = new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.Role, "Manager");
            res.Add(rm);

            var rmupt = new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.Folder, "Pending Tasks".loc(), 20, 2);
            rm.ChildItems.Add(rmupt);
            rmupt.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 1"));
            rmupt.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 2"));
            rmupt.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 3"));

            var rmd = new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.Folder, "Drafts".loc(), 0, 0);
            rm.ChildItems.Add(rmd);

            var rmc = new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.Folder, "Completed Tasks".loc(), 200, 0);
            rm.ChildItems.Add(rmc);
            rmc.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 1"));
            rmc.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 2"));
            rmc.ChildItems.Add(new TaskTreeItem(Guid.NewGuid(), TaskTreeItemType.TaskFolder, "Task Type 3"));

            return res;
        }

        public async Task<List<TaskItem>> GetTaskList(Guid folderId)
        {
            var res = new List<TaskItem>();
            var rnd = new Random();

            var q = rnd.Next(5, 30);
            for (int i = 0; i < q; i++)
                res.Add(new TaskItem()
                {
                    Id = Guid.NewGuid(),
                    Title = $"Task {i:00}",
                    Proirity = (TaskPriorityEnum) rnd.Next(5),
                    Created = DateTime.Today.AddHours(-rnd.Next(100, 200)),
                    Done = DateTime.Today.AddHours(-rnd.Next(50, 100)),
                    Sender = "admin",
                    IsNew = rnd.Next(100) % 2 == 0
                });
            return res;
        }
    }
}