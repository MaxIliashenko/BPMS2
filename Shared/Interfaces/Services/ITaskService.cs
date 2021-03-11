using System.Collections.Generic;
using BPMS.Shared.Layout;
using System.Threading.Tasks;

namespace BPMS.Shared.Interfaces.Services
{
    public interface ITaskService
    {
        Task<List<TaskTreeItem>> GetTaskTree();
    }
}