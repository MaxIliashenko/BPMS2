using BPMS.Shared.Layout;
using System.Collections.Generic;

namespace BPMS.Shared.Interfaces.Services
{
    public interface IMenuService
    {
        List<MenuItem> GetMenuItems();
    }
}
