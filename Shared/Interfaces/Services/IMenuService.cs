using BPMS.Shared.Layout;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BPMS.Shared.Interfaces.Services
{
    public interface IMenuService
    {
        Task<List<MenuItem>> GetMenuItems();
    }
}
